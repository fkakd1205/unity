using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  // LoadScene�� ����ϱ� ����

// Game3�� Director
public class Game3Director : MonoBehaviour
{
    private float time = 60.0f; // Game �ð� 60��
    private GameObject clock_text;    // �ð��� ǥ��
    private GameObject cat, vaccine, distance;    // cat�� ��ű��� ���� �Ÿ��� ǥ��
    private GameObject[] life;   // ����
    private int lifeNum = 3;    // ���� ����
    private float endTime = 0; // 60�� �� ���� ��

    void Start()
    {
        clock_text = GameObject.Find("clock_text");
        cat = GameObject.Find("cat");
        vaccine = GameObject.Find("vaccine");
        distance = GameObject.Find("distance");

        life = new GameObject[lifeNum];

        for (int i = 0; i < lifeNum; i++)
            life[i] = GameObject.Find("life" + (i + 1)); // life[0] ~ life[2] ����
    }

    // ���� ���� 2 > 1 > 0
    public void DecreaseLife()
    {
        // ���� lifeNum�� 3���� �����Ǿ������Ƿ� -1���ش�
        lifeNum--;

        // ���� ������ ������ ���� ����
        if (lifeNum == 0)
        {
            SceneManager.LoadScene("Game3_OverScene");
        }

        life[lifeNum].GetComponent<Image>().color = Color.black; // ����(��Ʈ) ���������� ����
    }

    void Update()
    {
        time -= Time.deltaTime;

        // ���� �÷��� ����Ǹ� �� �̵�
        if (time <= endTime)
            SceneManager.LoadScene("Game3_OverScene");

        clock_text.GetComponent<Text>().text = time.ToString("N1") + "��"; // �ð��� �Ҽ��� ��° �ڸ����� ���Ѵ�

        // cat�� ��� ������ x���� �Ÿ�
        float xLength = vaccine.transform.position.x - cat.transform.position.x;
        distance.GetComponent<Text>().text = "��� ������ ���� �Ÿ�\n" + xLength.ToString("F1");
    }
}
