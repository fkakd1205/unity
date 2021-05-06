using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game2의 마스크 Controller
public class MaskController : MonoBehaviour
{
    private GameObject director;
    private bool catchFlag = false; // 마스크 접촉 여부

    void Start()
    {
        director = GameObject.Find("Game2Director");
    }

    void Update()
    {
        // 마스크가 바닥에 떨어진 경우
        if(this.transform.position.y <= -4.5f)
        {
            //Debug.Log("마스크 놓쳤다");

            // 잡지 못한 후 떨어진 경우
            if (!catchFlag)
            {
                GameObject.Find("player_angry").GetComponent<AudioSource>().Play();

                // 생명 -1
                director.GetComponent<Game2Director>().DecreaseLife();
            }

            // 마스크 제거
            Destroy(gameObject);
        }
    }

    // 마스크를 손으로 잡았을 때 (오른손과 닿았을 때)
    void OnCollisionEnter(Collision other)
    {
        //Debug.Log("마스크 잡았다");

        // Player 웃는 소리
        GameObject.Find("player_laugh").GetComponent<AudioSource>().Play();

        // 생명 +1
        director.GetComponent<Game2Director>().IncreaseLife();

        catchFlag = true;
    }
}
