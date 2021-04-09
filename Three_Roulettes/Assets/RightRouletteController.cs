using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightRouletteController : MonoBehaviour
{
    float rotSpeed = 0;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButton(0)) // 마우스 왼쪽 버튼이 눌려져 있는 동안 계속 회전
        {
            this.rotSpeed = 10;
        }
        else
        {
            this.rotSpeed *= 0.99f; // 마우스 클릭을 해제하면 서서히 멈춤
        }

        transform.Rotate(0, 0, this.rotSpeed);

    }
}
