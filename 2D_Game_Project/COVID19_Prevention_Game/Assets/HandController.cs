using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game2의 손 Controller
public class HandController : MonoBehaviour
{
    private float handSpeed = 0;
    private GameObject generator;

    void Start()
    {
        generator = GameObject.Find("HandGenerator");
    }

    // 새로운 양손 생성
    void HandGenerate()
    {
        // 속도 0으로 변경
        handSpeed = 0;

        // 두손 삭제 후 새로운 두 손 생성 (HandGenerator.cs의 HandControll()호출)
        generator.GetComponent<HandGenerator>().HandControll();
    }

    void Update()
    {
        // Space키 누르면 손 이동하도록
        if (Input.GetKeyDown(KeyCode.Space))
        {
            handSpeed = 0.2f;
        }

        transform.Translate(0, handSpeed, 0);

        // 마스크를 못잡고 두 손이 교차할 때
        if (transform.position.x > 11.0f)
        {
            HandGenerate();
        }
    }

    // 마스크를 손으로 잡았을 때
    void OnCollisionEnter(Collision other)
    {
        HandGenerate();
    }
}
