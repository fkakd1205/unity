using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightRouletteController : MonoBehaviour
{
    float rotSpeed = 0;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButton(0)) // ���콺 ���� ��ư�� ������ �ִ� ���� ��� ȸ��
        {
            this.rotSpeed = 10;
        }
        else
        {
            this.rotSpeed *= 0.99f; // ���콺 Ŭ���� �����ϸ� ������ ����
        }

        transform.Rotate(0, 0, this.rotSpeed);

    }
}
