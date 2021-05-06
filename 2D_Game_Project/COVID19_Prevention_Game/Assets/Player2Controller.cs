using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// Game1 - Stage2 플레이어 Controller
public class Player2Controller : MonoBehaviour
{
    private float movePos = 1.625f;    //player 이동 크기

    void Update()
    {
        // 왼쪽 화살표 눌렸을 때
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        { 
            if(transform.position.x > -8.0f)   // 화면 x축 왼쪽으로 벗어나지 못하도록 제어
                transform.Translate(this.movePos * -1, 0, 0);   // 왼쪽으로 movePos만큼 이동.
        }

        // 오른쪽 화살표 눌렸을 때
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if(transform.position.x < 8.0f)    // 화면 x축 오른쪽으로 벗어나지 못하도록 제어
                transform.Translate(this.movePos, 0, 0);    // 오른쪽으로 movePos만큼 이동.
        }

        // 위쪽 화살표 눌렸을 때
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(transform.position.y < 4.0f)    // 화면 y축 위로 벗어나지 못하도록 제어
                transform.Translate(0, this.movePos, 0);    // 위쪽으로 movePos만큼 이동.
        }

        // 아래쪽 화살표 눌렸을 때
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if(transform.position.y > -2.0f)   // 화면 y축 아래로 벗어나지 못하도록 제어
                transform.Translate(0, this.movePos * -1, 0);    // 아래쪽으로 movePos만큼 이동.
        }
    }
}
