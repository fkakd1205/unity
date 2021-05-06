using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game1 - Stage1, Stage2의 백신 Controller
public class VaccineController : MonoBehaviour
{
    private float span = 3.0f;  // 백신 생성 후 일정 시간 이후 삭제
    private float delta = 0;

    void Update()
    {
        delta += Time.deltaTime;

        // 백신 생성 후 3초 지나면 삭제
        if (delta > span)
        {
            Destroy(gameObject);
        }

        // 백신 Fade In
        if (delta < span)
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, delta);
        }
    }

    // 백신 player와 충돌했을 경우 아이템 삭제.
    void OnCollisionEnter2D(Collision2D other)
    {
        //Debug.Log("백신 획득!! 회복 +20");

        GameObject.Find("player_big_laugh").GetComponent<AudioSource>().Play(); // Player 환호 소리

        // 감염도 20 감소
        GameObject director = GameObject.Find("GameDirector");
        director.GetComponent<GameDirector>().DecreaseGauge(0.2f);

        Destroy(gameObject);
    }
}
