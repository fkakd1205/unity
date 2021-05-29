using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    GameObject blackcat;

    void Start()
    {
        this.blackcat = GameObject.Find("blackcat");
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

        
        //�浹 ����
        Vector2 p1 = transform.position;    //�÷��̾� �߽� ��ǥ
        Vector2 p2 = this.blackcat.transform.position;    //blackcat �߽� ��ǥ
        Vector2 dir = p1 - p2;

        float d = dir.magnitude;    //d�� blackcat�� �÷��̾� ���� �Ÿ�
        float r1 = 1.5f;    //blackcat �ݰ�
        float r2 = 1.0f;    //�÷��̾� �ݰ�

        if (d < r1 + r2) //blackcat�� �÷��̾� �浹�� ���
        {
            //�浹�� ��� player �Ҹ�
            Destroy(gameObject);
         }
    }
}
