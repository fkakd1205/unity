using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleRouletteController : MonoBehaviour
{
    float rotSpeed = 0;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))    // ���콺 ���� ��ư�� ������ ��
        {
            this.rotSpeed = 10;
        }

        if (Input.GetMouseButtonDown(1)){   // ���콺 ������ ��ư�� ���������� ȸ���� -1 (���� ȸ�� �ӵ��� 10�̹Ƿ� 10�� Ŭ���ϸ� ����)
            if(this.rotSpeed != 0)  // ���� �귿�� ȸ���ϰ� �ִٸ�
                this.rotSpeed -= 1;
        }

        transform.Rotate(0, 0, this.rotSpeed);  // rotSpeed��ŭ ȸ��
    }
}
