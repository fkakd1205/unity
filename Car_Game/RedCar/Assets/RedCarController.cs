using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))    // 마우스를 눌렀을 때 마우스의 좌표
        {
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))    // 마우스에서 손을 떼었을 때 마우스의 좌표
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = (endPos.x - this.startPos.x);

            this.speed = swipeLength / 500.0f;
        }

        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;
    }
}
