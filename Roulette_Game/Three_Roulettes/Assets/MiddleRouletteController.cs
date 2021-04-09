using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleRouletteController : MonoBehaviour
{
    float rotSpeed = 0;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))    // 마우스 왼쪽 버튼이 눌렸을 때
        {
            this.rotSpeed = 10;
        }

        if (Input.GetMouseButtonDown(1)){   // 마우스 오른쪽 버튼을 누를때마다 회전값 -1 (현재 회전 속도가 10이므로 10번 클릭하면 멈춤)
            if(this.rotSpeed != 0)  // 현재 룰렛이 회전하고 있다면
                this.rotSpeed -= 1;
        }

        transform.Rotate(0, 0, this.rotSpeed);  // rotSpeed만큼 회전
    }
}
