using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCatController : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        this.player = GameObject.Find("player") != null ? GameObject.Find("player") : null;
    }

    void Update()
    {
        //위쪽 화살표 눌렸을 때
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(2, 0, 0);   //오른쪽으로 2 이동.
        }

        //아래쪽 화살표 눌렸을 때
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(-2, 0, 0);    //왼쪽으로 2 이동.
        }

        if (player != null)
        {
            //충돌 판정
            Vector2 p1 = transform.position;    //yellow cat 중심 좌표
            Vector2 p2 = this.player.transform.position;    //플레이어 중심 좌표
            Vector2 dir = p1 - p2;

            float d = dir.magnitude;    //d는 yellow cat과 플레이어 간의 거리
            float r1 = 1.5f;    //yellow cat 반경
            float r2 = 1.0f;    //플레이어 반경

            if (d < r1 + r2) //화살과 플레이어 충돌한 경우
            {
                //충돌한 경우 yellow cat 왼쪽으로 이동, player는 오른쪽으로 이동.
                transform.Translate(-3, 0, 0);
                this.player.transform.Translate(1, 0, 0);
            }
        }
    }
}
