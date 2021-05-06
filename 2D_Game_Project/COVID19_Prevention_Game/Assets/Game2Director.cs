using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  // LoadScene을 사용하기 위해

// Game2의 Director
public class Game2Director : MonoBehaviour
{
    private float time = 60.0f; // Game 시간 60초
    private GameObject clock_text;    // 시간을 표시
    private GameObject[] life;   // 생명
    private int lifeNum = 3;    // 생명 개수
    private int catchNum = 0;   // 손 몇개가 마스크에 부딪혔는지
    private float endTime = 0; // 60초 후 게임 끝

    void Start()
    {
        clock_text = GameObject.Find("clock_text");
        life = new GameObject[lifeNum];

        for (int i = 0; i < lifeNum; i++)
            this.life[i] = GameObject.Find("life" + (i+1)); // life[0] ~ life[2] 설정
    }

    // 생명 감소 2 > 1 > 0
    public void DecreaseLife()
    {
        // 먼저 lifeNum을 3으로 지정되어있으므로 -1해준다
        lifeNum--;

        // 남은 생명이 없으면 게임 종료
        if(lifeNum == 0)
        {
            SceneManager.LoadScene("Game2_OverScene");
        }

        life[lifeNum].GetComponent<Image>().color = Color.black; // 생명(하트) 검정색으로 변경
    }

    // 생명 증가 0 > 1 > 2
    public void IncreaseLife()
    {
        catchNum++;

        // 손 두개 ->  Collider감지 2개
        if(catchNum == 2)
        {
            catchNum = 0;

            if(lifeNum < 3)
                life[lifeNum++].GetComponent<Image>().color = Color.white; // 생명(하트) 원래 색으로 변경
        }
    }

    void Update()
    {
        time -= Time.deltaTime;

        // 게임 플레이 종료되면 씬 이동
        if (time <= endTime)
            SceneManager.LoadScene("Game2_ClearScene");

        clock_text.GetComponent<Text>().text = time.ToString("N1") + "초"; // 시간을 소수점 둘째 자리까지 구한다
    }
}
