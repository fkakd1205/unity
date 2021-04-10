using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{

    void Start()
    {
    }

    void Update()
    {
        // 왼쪽 화살표 눌렸을 때
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-2, 0, 0);   // 왼쪽으로 2 이동.
        }

        // 오른쪽 화살표 눌렸을 때
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(2, 0, 0);    // 오른쪽으로 2 이동.
        }

        // 위쪽 화살표 눌렸을 때
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(0, 2, 0);    // 위쪽으로 2 이동.
        }

        // 아래쪽 화살표 눌렸을 때
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(0, -2, 0);    // 아래쪽으로 2 이동.
        }

    }
}
