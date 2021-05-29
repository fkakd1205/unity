using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star2Controller : MonoBehaviour
{
    float rot = -0.05f;
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("player");
    }

    void Update()
    {
        if (transform.position.y < -3)
            rot *= -1;
        else if (transform.position.y > 3.5)
            rot *= -1;

        transform.Translate(0, this.rot, 0);

        //충돌 판정
        Vector2 p1 = transform.position;    //star2 중심 좌표
        Vector2 p2 = this.player.transform.position;    //플레이어 중심 좌표
        Vector2 dir = p1 - p2;

        float d = dir.magnitude;    //d는 star2과 플레이어 간의 거리
        float r1 = 1.0f;    //star2 반경
        float r2 = 1.0f;    //플레이어 반경

        if (d < r1 + r2) //star2과 플레이어 충돌한 경우
        {
            GameObject director = GameObject.Find("GameDirector");  //이름이 "GameDirector"인 GameObject
            director.GetComponent<GameDirector>().resetHp(); //GameDirector 스크립트에 있는 public 메소드 IncreaseHp() 호출
        }
    }
}
