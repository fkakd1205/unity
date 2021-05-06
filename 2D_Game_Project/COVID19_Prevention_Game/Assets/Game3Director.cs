using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  // LoadScene을 사용하기 위해

// Game3의 Director
public class Game3Director : MonoBehaviour
{
    private float time = 60.0f; // Game 시간 60초
    private GameObject clock_text;    // 시간을 표시
    private GameObject cat, vaccine, distance;    // cat과 백신까지 남은 거리를 표시
    private GameObject[] life;   // 생명
    private int lifeNum = 3;    // 생명 개수
    private float endTime = 0; // 60초 후 게임 끝

    void Start()
    {
        clock_text = GameObject.Find("clock_text");
        cat = GameObject.Find("cat");
        vaccine = GameObject.Find("vaccine");
        distance = GameObject.Find("distance");

        life = new GameObject[lifeNum];

        for (int i = 0; i < lifeNum; i++)
            life[i] = GameObject.Find("life" + (i + 1)); // life[0] ~ life[2] 설정
    }

    // 생명 감소 2 > 1 > 0
    public void DecreaseLife()
    {
        // 먼저 lifeNum이 3으로 지정되어있으므로 -1해준다
        lifeNum--;

        // 남은 생명이 없으면 게임 종료
        if (lifeNum == 0)
        {
            SceneManager.LoadScene("Game3_OverScene");
        }

        life[lifeNum].GetComponent<Image>().color = Color.black; // 생명(하트) 검정색으로 변경
    }

    void Update()
    {
        time -= Time.deltaTime;

        // 게임 플레이 종료되면 씬 이동
        if (time <= endTime)
            SceneManager.LoadScene("Game3_OverScene");

        clock_text.GetComponent<Text>().text = time.ToString("N1") + "초"; // 시간을 소수점 둘째 자리까지 구한다

        // cat과 백신 사이의 x사이 거리
        float xLength = vaccine.transform.position.x - cat.transform.position.x;
        distance.GetComponent<Text>().text = "백신 까지의 남은 거리\n" + xLength.ToString("F1");
    }
}
