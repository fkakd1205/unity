using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedFlagController : MonoBehaviour
{
    int rotSpeed = 0;
    int rotateVal = 10;

    void Start()
    {
    }

    
    void Update()
    {  
        // 마우스 가운데 버튼을 눌렀을 때
        if (Input.GetMouseButtonDown(2))
        {
            if (this.rotSpeed != 0)
                rotateVal = 0;
            else
                rotateVal = 10;
        }

        this.rotSpeed = rotateVal;

        transform.Rotate(0, this.rotSpeed, 0);  // RedFlag회전
    }
}
