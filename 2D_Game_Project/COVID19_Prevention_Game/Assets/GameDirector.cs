using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  // LoadScene을 사용하기 위해

// Game1 -  Stage1, Stage2의 Director
public class GameDirector : MonoBehaviour
{
    private float time = 60.0f; // Game 시간 60초
    private GameObject clock_text;    // 시간을 표시
    private GameObject infection_gauge; // 감염도

    float zoomTime = 30.0f; // 30초 후에 clock_text 색상 변경
    float endTime = 0; // 60초 후 게임 끝

    void Start()
    {
        this.clock_text = GameObject.Find("clock_text");
        this.infection_gauge = GameObject.Find("infection_gauge");
    }

    // 감염도 증가
    public void IncreaseGauge(float amount)
    {
        this.infection_gauge.GetComponent<Image>().fillAmount += amount;    // amount만큼 감염도 증가

        if (this.infection_gauge.GetComponent<Image>().fillAmount >= 1.0f) SceneManager.LoadScene("Game1_OverScene"); // 감염도가 100%증가했다면 Game1_OverScene으로 이동
    }

    // 감염도 감소
    public void DecreaseGauge(float amount)
    {
        this.infection_gauge.GetComponent<Image>().fillAmount -= amount;    // amount만큼 감염도 감소
    }

    void Update()
    {
        time -= Time.deltaTime;

        // 카메라 줌 되면 시간UI 텍스트 색 변경
        if (time < zoomTime)
            this.clock_text.GetComponent<Text>().color = Color.blue;

        if (time <= endTime)
            SceneManager.LoadScene("Game1_ClearScene");

        this.clock_text.GetComponent<Text>().text = time.ToString("N1") + "초"; // 시간을 소수점 둘째 자리까지 구한다
    }
}
