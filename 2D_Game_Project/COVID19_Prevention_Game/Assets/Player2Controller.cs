using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// Game1 - Stage2 �÷��̾� Controller
public class Player2Controller : MonoBehaviour
{
    private float movePos = 1.625f;    //player �̵� ũ��

    void Update()
    {
        // ���� ȭ��ǥ ������ ��
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        { 
            if(transform.position.x > -8.0f)   // ȭ�� x�� �������� ����� ���ϵ��� ����
                transform.Translate(this.movePos * -1, 0, 0);   // �������� movePos��ŭ �̵�.
        }

        // ������ ȭ��ǥ ������ ��
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if(transform.position.x < 8.0f)    // ȭ�� x�� ���������� ����� ���ϵ��� ����
                transform.Translate(this.movePos, 0, 0);    // ���������� movePos��ŭ �̵�.
        }

        // ���� ȭ��ǥ ������ ��
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(transform.position.y < 4.0f)    // ȭ�� y�� ���� ����� ���ϵ��� ����
                transform.Translate(0, this.movePos, 0);    // �������� movePos��ŭ �̵�.
        }

        // �Ʒ��� ȭ��ǥ ������ ��
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if(transform.position.y > -2.0f)   // ȭ�� y�� �Ʒ��� ����� ���ϵ��� ����
                transform.Translate(0, this.movePos * -1, 0);    // �Ʒ������� movePos��ŭ �̵�.
        }
    }
}