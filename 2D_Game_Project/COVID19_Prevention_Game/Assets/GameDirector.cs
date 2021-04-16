using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    private float time;
    GameObject clock;    // 시간을 표시
    GameObject infection_gauge;

    void Start()
    {
        this.clock = GameObject.Find("clock");
        this.infection_gauge = GameObject.Find("infection_gauge");
    }

    // 감염도 증가
    public void IncreaseGauge(float amount)
    {
        this.infection_gauge.GetComponent<Image>().fillAmount += amount;
    }

    // 감염도 감소
    public void DecreaseGauge(float amount)
    {
        this.infection_gauge.GetComponent<Image>().fillAmount -= amount;
    }

    void Update()
    {
        time += Time.deltaTime;

        this.clock.GetComponent<Text>().text = time.ToString("N2") + "초"; // 시간을 소수점 둘째 자리까지 구한다
    }
}
