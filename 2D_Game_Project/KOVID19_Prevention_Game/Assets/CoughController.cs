using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoughController : MonoBehaviour
{
    int coughDirection;

    void Start()
    {

    }

    void Update()
    {
        // 프레임마다 등속으로 기침 이동
        transform.Translate(0, -0.03f, 0);

        //
        if(transform.position.x < -9.0f || transform.position.x > 9.0f)
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
