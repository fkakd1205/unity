using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {

    }

    // 아이템이 player와 충돌했을 경우 아이템 삭제.
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("아이템 획득!! 회복 +10");
        Destroy(gameObject);
    }
}
