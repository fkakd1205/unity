using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game3의 기침 Controller
public class Cough3Controller : MonoBehaviour
{
    private float coughSpeed = -0.04f;  // 기침 속도

    void Update()
    {
        // 등속으로 이동
        transform.Translate(0, coughSpeed, 0);

        // 기침의 x좌표가 게임 맵 맨 왼쪽까지 도달하면 삭제
        if (transform.position.x < -12.0f)
        {
            Destroy(gameObject);
        }
    }

    // 기침이 cat과 충돌했을 경우 기침 삭제.
    void OnCollisionEnter2D(Collision2D other)
    {
        //Debug.Log("침 맞음!! 생명 -1");

        // Player 화난 소리
        GameObject.Find("player_angry").GetComponent<AudioSource>().Play();

        // 생명 -1
        GameObject director = GameObject.Find("Game3Director");
        director.GetComponent<Game3Director>().DecreaseLife();

        Destroy(gameObject);
    }
}
