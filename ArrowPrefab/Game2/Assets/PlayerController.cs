using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    GameObject blackcat;

    void Start()
    {
    }

    void Update()
    {
        //���� ȭ��ǥ ������ ��
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0);   //�������� 3 �̵�.
        }

        //������ ȭ��ǥ ������ ��
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0);    //���������� 3 �̵�.
        }
    }
}
