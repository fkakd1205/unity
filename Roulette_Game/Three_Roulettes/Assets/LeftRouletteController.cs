using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRouletteController : MonoBehaviour
{
    float rotSpeed = 0;
    bool rotFlag = false;   // 회전 여부 (회전 - true, 회전X - false)

    void Start()
    {
    }

    // 룰렛의 결과를 출력하는 함수
    void rouletteResult()
    {
        if (this.rotFlag == true)    // 룰렛을 돌렸을 때만 결과 출력
        {
            float objAngle = transform.rotation.eulerAngles.z; // left_roulette의 z회전 각도 (0부터 360까지의 값만 취급)
            string rouletteResult = "";

            // 룰렛의 z값 각도에 따라 결과 출력
            if (objAngle > 30 && objAngle <= 90) rouletteResult += "대통";
            else if (objAngle > 90 && objAngle <= 150) rouletteResult += "매우나쁨";
            else if (objAngle > 150 && objAngle <= 210) rouletteResult += "보통";
            else if (objAngle > 211 && objAngle <= 270) rouletteResult += "조심";
            else if (objAngle > 271 && objAngle <= 330) rouletteResult += "좋음";
            else rouletteResult += "나쁨";

            Debug.Log("Left Roulette의 결과 : 운수" + rouletteResult);

            this.rotFlag = false;   // 결과 출력 후 회전 여부 false로 변경
        }
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){   // 마우스 왼쪽 버튼이 눌렸을 때
            this.rotSpeed = 10;
            this.rotFlag = true;    // 회전 여부 true로 변경
        }

        this.rotSpeed *= 0.96f;

        transform.Rotate(0, 0, this.rotSpeed);

        // 어느정도 속도가 감소되면 완전히 멈추도록 변경.
        if(this.rotSpeed < 0.1)
        {
            this.rotSpeed = 0;
            rouletteResult();   // 룰렛의 결과 출력
        }

    }


}
