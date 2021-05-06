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
        if (Input.GetMouseButtonDown(0))    // 마우스 왼쪽 버튼을 눌렀을 때
        {
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))    // 마우스에서 왼쪽 버튼에서 손을 떼었을 때
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = (endPos.x - this.startPos.x);

            this.speed = swipeLength / 500.0f;
        }

        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;
    }
}
