using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    GameObject blackcat;

    void Start()
    {
        this.blackcat = GameObject.Find("blackcat");
    }

    void Update()
    {
        //왼쪽 화살표 눌렸을 때
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0);   //왼쪽으로 3 이동.
        }

        //오른쪽 화살표 눌렸을 때
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0);    //오른쪽으로 3 이동.
        }

        
        //충돌 판정
        Vector2 p1 = transform.position;    //플레이어 중심 좌표
        Vector2 p2 = this.blackcat.transform.position;    //blackcat 중심 좌표
        Vector2 dir = p1 - p2;

        float d = dir.magnitude;    //d는 blackcat과 플레이어 간의 거리
        float r1 = 1.5f;    //blackcat 반경
        float r2 = 1.0f;    //플레이어 반경

        if (d < r1 + r2) //blackcat과 플레이어 충돌한 경우
        {
            //충돌한 경우 player 소멸
            Destroy(gameObject);
         }
    }
}
