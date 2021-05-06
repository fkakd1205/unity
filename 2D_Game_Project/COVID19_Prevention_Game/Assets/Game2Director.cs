using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  // LoadScene�� ����ϱ� ����

// Game2�� Director
public class Game2Director : MonoBehaviour
{
    private float time = 60.0f; // Game �ð� 60��
    private GameObject clock_text;    // �ð��� ǥ��
    private GameObject[] life;   // ����
    private int lifeNum = 3;    // ���� ����
    private int catchNum = 0;   // �� ��� ����ũ�� �ε�������
    private float endTime = 0; // 60�� �� ���� ��

    void Start()
    {
        clock_text = GameObject.Find("clock_text");
        life = new GameObject[lifeNum];

        for (int i = 0; i < lifeNum; i++)
            this.life[i] = GameObject.Find("life" + (i+1)); // life[0] ~ life[2] ����
    }

    // ���� ���� 2 > 1 > 0
    public void DecreaseLife()
    {
        // ���� lifeNum�� 3���� �����Ǿ������Ƿ� -1���ش�
        lifeNum--;

        // ���� ������ ������ ���� ����
        if(lifeNum == 0)
        {
            SceneManager.LoadScene("Game2_OverScene");
        }

        life[lifeNum].GetComponent<Image>().color = Color.black; // ����(��Ʈ) ���������� ����
    }

    // ���� ���� 0 > 1 > 2
    public void IncreaseLife()
    {
        catchNum++;

        // �� �ΰ� ->  Collider���� 2��
        if(catchNum == 2)
        {
            catchNum = 0;

            if(lifeNum < 3)
                life[lifeNum++].GetComponent<Image>().color = Color.white; // ����(��Ʈ) ���� ������ ����
        }
    }

    void Update()
    {
        time -= Time.deltaTime;

        // ���� �÷��� ����Ǹ� �� �̵�
        if (time <= endTime)
            SceneManager.LoadScene("Game2_ClearScene");

        clock_text.GetComponent<Text>().text = time.ToString("N1") + "��"; // �ð��� �Ҽ��� ��° �ڸ����� ���Ѵ�
    }
}
