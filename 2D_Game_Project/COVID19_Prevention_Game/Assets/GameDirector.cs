using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    private float time;
    GameObject clock;    // �ð��� ǥ��
    GameObject infection_gauge;

    void Start()
    {
        this.clock = GameObject.Find("clock");
        this.infection_gauge = GameObject.Find("infection_gauge");
    }

    // ������ ����
    public void IncreaseGauge(float amount)
    {
        this.infection_gauge.GetComponent<Image>().fillAmount += amount;
    }

    // ������ ����
    public void DecreaseGauge(float amount)
    {
        this.infection_gauge.GetComponent<Image>().fillAmount -= amount;
    }

    void Update()
    {
        time += Time.deltaTime;

        this.clock.GetComponent<Text>().text = time.ToString("N2") + "��"; // �ð��� �Ҽ��� ��° �ڸ����� ���Ѵ�
    }
}
