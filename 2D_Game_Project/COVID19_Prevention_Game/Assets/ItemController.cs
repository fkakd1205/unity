using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game1 - Stage1의 아이템 Controller
public class ItemController : MonoBehaviour
{
    private float span = 3.0f;  // 아이템 생성 후 일정 시간 이후 삭제
    private float delta = 0;

    void Update()
    {
        delta += Time.deltaTime;

        // 아이템 생성 후 3초 지나면 삭제
        if (delta > span)
        {
            Destroy(gameObject);
        }

        // 아이템 Fade In
        if(delta < span)
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, delta);
        }
    }

    // 아이템이 player와 충돌했을 경우 아이템 삭제.
    void OnCollisionEnter2D(Collision2D other)
    {
        //Debug.Log("아이템 획득!! 회복 +10");
        
        // Player 웃음 소리
        GameObject.Find("player_laugh").GetComponent<AudioSource>().Play();

        // 감염도 10 감소
        GameObject director = GameObject.Find("GameDirector");
        director.GetComponent<GameDirector>().DecreaseGauge(0.1f);

        // 아이템 삭제
        Destroy(gameObject);
    }
}
