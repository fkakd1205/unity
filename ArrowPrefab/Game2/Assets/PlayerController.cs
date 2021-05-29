using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    GameObject blackcat;

    void Start()
    {
    }

    void Update()
    {
        //왼쪽 화살표 눌렸을 때
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0);   //왼쪽으로 3 이동.
        }

        //오른쪽 화살표 눌렸을 때
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0);    //오른쪽으로 3 이동.
        }
    }
}
