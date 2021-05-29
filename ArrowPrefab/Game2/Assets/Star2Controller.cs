using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star2Controller : MonoBehaviour
{
    float rot = -0.05f;
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("player");
    }

    void Update()
    {
        if (transform.position.y < -3)
            rot *= -1;
        else if (transform.position.y > 3.5)
            rot *= -1;

        transform.Translate(0, this.rot, 0);

        //�浹 ����
        Vector2 p1 = transform.position;    //star2 �߽� ��ǥ
        Vector2 p2 = this.player.transform.position;    //�÷��̾� �߽� ��ǥ
        Vector2 dir = p1 - p2;

        float d = dir.magnitude;    //d�� star2�� �÷��̾� ���� �Ÿ�
        float r1 = 1.0f;    //star2 �ݰ�
        float r2 = 1.0f;    //�÷��̾� �ݰ�

        if (d < r1 + r2) //star2�� �÷��̾� �浹�� ���
        {
            GameObject director = GameObject.Find("GameDirector");  //�̸��� "GameDirector"�� GameObject
            director.GetComponent<GameDirector>().resetHp(); //GameDirector ��ũ��Ʈ�� �ִ� public �޼ҵ� IncreaseHp() ȣ��
        }
    }
}
