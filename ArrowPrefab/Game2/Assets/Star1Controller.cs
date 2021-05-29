using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star1Controller : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("player");
    }

    void Update()
    {
        //�����Ӹ��� ������� ����, ȸ���ϸ鼭 �̵� -> �۷ι� �� �������� ��.
        transform.Translate(0, -0.1f, 0, Space.World);
        transform.Rotate(0, 0, 5, Space.World);

        //ȭ�� ������ ������ ������Ʈ ����
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        //�浹 ����
        Vector2 p1 = transform.position;    //star1 �߽� ��ǥ
        Vector2 p2 = this.player.transform.position;    //�÷��̾� �߽� ��ǥ
        Vector2 dir = p1 - p2;

        float d = dir.magnitude;    //d�� star1�� �÷��̾� ���� �Ÿ�
        float r1 = 0.5f;    //star1 �ݰ�
        float r2 = 1.0f;    //�÷��̾� �ݰ�

        if (d < r1 + r2) //star1�� �÷��̾� �浹�� ���
        {
            GameObject director = GameObject.Find("GameDirector");  //�̸��� "GameDirector"�� GameObject
            director.GetComponent<GameDirector>().IncreaseHp(); //GameDirector ��ũ��Ʈ�� �ִ� public �޼ҵ� IncreaseHp() ȣ��

            //�浹�� ��� star1 �Ҹ�
            Destroy(gameObject);
        }
    }
}
