using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{

    void Start()
    {
    }

    void Update()
    {
        // ���� ȭ��ǥ ������ ��
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-2, 0, 0);   // �������� 2 �̵�.
        }

        // ������ ȭ��ǥ ������ ��
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(2, 0, 0);    // ���������� 2 �̵�.
        }

        // ���� ȭ��ǥ ������ ��
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(0, 2, 0);    // �������� 2 �̵�.
        }

        // �Ʒ��� ȭ��ǥ ������ ��
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(0, -2, 0);    // �Ʒ������� 2 �̵�.
        }

    }
}
