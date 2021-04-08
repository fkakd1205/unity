using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roulette : MonoBehaviour
{
    // 회전 속도
    float rotSpeed = 0;

    void Start()
    {
        
    }

    void Update()
    {
        // GetMouseButtonDown(0) 왼쪽 마우스 버튼을 눌렀을 때 실행. (0-왼쪽, 1-오른쪽, 2-가운데 클릭)
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10; // 룰렛의 회전 속도
        }

        transform.Rotate(0, 0, this.rotSpeed);  // 회전 속도만큼 룰렛을 회전시킨다.

        this.rotSpeed *= 0.96f; // 감속계수=0.96 을 사용해 룰렛 정지. 스프링 진동 감쇠 등에 사용.
    }
}
