using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roulette : MonoBehaviour
{
    // ȸ�� �ӵ�
    float rotSpeed = 0;

    void Start()
    {
        
    }

    void Update()
    {
        // GetMouseButtonDown(0) ���� ���콺 ��ư�� ������ �� ����. (0-����, 1-������, 2-��� Ŭ��)
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10; // �귿�� ȸ�� �ӵ�
        }

        transform.Rotate(0, 0, this.rotSpeed);  // ȸ�� �ӵ���ŭ �귿�� ȸ����Ų��.

        this.rotSpeed *= 0.96f; // ���Ӱ��=0.96 �� ����� �귿 ����. ������ ���� ���� � ���.
    }
}
