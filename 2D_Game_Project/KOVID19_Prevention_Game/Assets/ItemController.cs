using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    float span = 3.0f;  // 아이템 생성 후 일정 시간 이후 삭제
    float delta = 0;

    void Start()
    {
        
    }

    void Update()
    {
        this.delta += Time.deltaTime;

        // 아이템 생성 후 3초 지나면 삭제
        if (this.delta > this.span)
        {
            Destroy(gameObject);
        }
    }

    // 아이템이 player와 충돌했을 경우 아이템 삭제.
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("아이템 획득!! 회복 +10");
        Destroy(gameObject);
    }
}
