using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaccineController : MonoBehaviour
{
    float span = 3.0f;  // 백신 생성 후 일정 시간 이후 삭제
    float delta = 0;

    void Start()
    {
        
    }

    void Update()
    {
        this.delta += Time.deltaTime;

        // 백신 생성 후 3초 지나면 삭제
        if (this.delta > this.span)
        {
            Destroy(gameObject);
        }
    }

    // 백신 player와 충돌했을 경우 아이템 삭제.
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("백신 획득!! 회복 +20");

        // 감염도 20 감소
        GameObject director = GameObject.Find("GameDirector");
        director.GetComponent<GameDirector>().DecreaseGauge(0.2f);

        Destroy(gameObject);
    }
}
