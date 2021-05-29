using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("player");
    }

    void Update()
    {
        //프레임마다 등속으로 낙하
        transform.Translate(0, -0.1f, 0);

        //화면 밖으로 나오면 오브젝트 삭제
        if(transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        //충돌 판정
        Vector2 p1 = transform.position;    //화살 중심 좌표
        Vector2 p2 = this.player.transform.position;    //플레이어 중심 좌표
        Vector2 dir = p1 - p2;

        float d = dir.magnitude;    //d는 화살과 플레이어 간의 거리
        float r1 = 0.5f;    //화살 반경
        float r2 = 1.0f;    //플레이어 반경

        if (d < r1 + r2) //화살과 플레이어 충돌한 경우
        {
            GameObject director = GameObject.Find("GameDirector");  //이름이 "GameDirector"인 GameObject
            director.GetComponent<GameDirector>().DecreaseHp(); //GameDirector 스크립트에 있는 public 메소드 DecreaseHp() 호출

            //충돌한 경우 화살 소멸
            Destroy(gameObject);
         }
    }
}
