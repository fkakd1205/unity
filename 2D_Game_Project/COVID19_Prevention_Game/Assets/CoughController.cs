using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoughController : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        // 랜덤한 스피드로 기침 발사 
        float coughSpeed = Random.Range(-0.01f, -0.05f);
        // 등속으로 이동
        transform.Translate(0, coughSpeed, 0);

        // 기침의 x좌표가 반대편 사람의 x좌표에 닿으면 기침 삭제
        if (transform.position.x < -9.0f || transform.position.x > 9.0f)
        {
            Destroy(gameObject);
        }
    }

    // 기침이 player와 충돌했을 경우 기침 삭제.
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("침 맞음!! 감염도 -10");
        Destroy(gameObject);
    }
}
