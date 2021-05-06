using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  // LoadScene�� ����ϱ� ����

// Game1 -  Stage1, Stage2�� Director
public class GameDirector : MonoBehaviour
{
    private float time = 60.0f; // Game �ð� 60��
    private GameObject clock_text;    // �ð��� ǥ��
    private GameObject infection_gauge; // ������

    float zoomTime = 30.0f; // 30�� �Ŀ� clock_text ���� ����
    float endTime = 0; // 60�� �� ���� ��

    void Start()
    {
        this.clock_text = GameObject.Find("clock_text");
        this.infection_gauge = GameObject.Find("infection_gauge");
    }

    // ������ ����
    public void IncreaseGauge(float amount)
    {
        this.infection_gauge.GetComponent<Image>().fillAmount += amount;    // amount��ŭ ������ ����

        if (this.infection_gauge.GetComponent<Image>().fillAmount >= 1.0f) SceneManager.LoadScene("Game1_OverScene"); // �������� 100%�����ߴٸ� Game1_OverScene���� �̵�
    }

    // ������ ����
    public void DecreaseGauge(float amount)
    {
        this.infection_gauge.GetComponent<Image>().fillAmount -= amount;    // amount��ŭ ������ ����
    }

    void Update()
    {
        time -= Time.deltaTime;

        // ī�޶� �� �Ǹ� �ð�UI �ؽ�Ʈ �� ����
        if (time < zoomTime)
            this.clock_text.GetComponent<Text>().color = Color.blue;

        if (time <= endTime)
            SceneManager.LoadScene("Game1_ClearScene");

        this.clock_text.GetComponent<Text>().text = time.ToString("N1") + "��"; // �ð��� �Ҽ��� ��° �ڸ����� ���Ѵ�
    }
}
