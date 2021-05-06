using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game3의 사람들 Controller
public class PersonController : MonoBehaviour
{

    // cat이 사람들과 부딪혔을 때
    void OnCollisionEnter2D(Collision2D other)
    {
        //Debug.Log("사람들과 충돌! 생명 -1");

        // Player 화난 소리
        GameObject.Find("player_angry").GetComponent<AudioSource>().Play();

        // 생명 -1
        GameObject director = GameObject.Find("Game3Director");
        director.GetComponent<Game3Director>().DecreaseLife();
    }
}
