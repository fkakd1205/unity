using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))    // ���콺 ���� ��ư�� ������ ��
        {
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(1))    // ���콺���� ���� ��ư���� ���� ������ ��
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = (this.startPos.y - endPos.y);

            this.speed = swipeLength / 500.0f;
        }

        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;
    }
}
