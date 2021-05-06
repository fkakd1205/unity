using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game1 - Stage1, Stage2의 기침 Controller
public class CoughController : MonoBehaviour
{
    private float coughSpeed;

    void Update()
    {
        // 랜덤한 스피드로 기침 발사 
        coughSpeed = Random.Range(-0.02f, -0.1f);

        // 등속으로 이동
        transform.Translate(0, coughSpeed, 0);

        // 기침의 x좌표가 반대편 사람의 x좌표에 닿으면 기침 삭제
        if (transform.position.x < -9.0f || transform.position.x > 9.0f)
        {
            Destroy(gameObject);
        }
    }

    // 기침이 player와 충돌했을 경우
    void OnCollisionEnter2D(Collision2D other)
    {
        //Debug.Log("침 맞음!! 감염도 +30");

        // Player 화난 소리
        GameObject.Find("player_angry").GetComponent<AudioSource>().Play();

        // 감염도 30 증가
        GameObject director = GameObject.Find("GameDirector");
        director.GetComponent<GameDirector>().IncreaseGauge(0.3f);

        Destroy(gameObject);    // 기침 삭제
    }
}
