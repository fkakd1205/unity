using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCatController : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        this.player = GameObject.Find("player") != null ? GameObject.Find("player") : null;
    }

    void Update()
    {
        //���� ȭ��ǥ ������ ��
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(2, 0, 0);   //���������� 2 �̵�.
        }

        //�Ʒ��� ȭ��ǥ ������ ��
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(-2, 0, 0);    //�������� 2 �̵�.
        }

        if (player != null)
        {
            //�浹 ����
            Vector2 p1 = transform.position;    //yellow cat �߽� ��ǥ
            Vector2 p2 = this.player.transform.position;    //�÷��̾� �߽� ��ǥ
            Vector2 dir = p1 - p2;

            float d = dir.magnitude;    //d�� yellow cat�� �÷��̾� ���� �Ÿ�
            float r1 = 1.5f;    //yellow cat �ݰ�
            float r2 = 1.0f;    //�÷��̾� �ݰ�

            if (d < r1 + r2) //ȭ��� �÷��̾� �浹�� ���
            {
                //�浹�� ��� yellow cat �������� �̵�, player�� ���������� �̵�.
                transform.Translate(-3, 0, 0);
                this.player.transform.Translate(1, 0, 0);
            }
        }
    }
}
