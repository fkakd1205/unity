using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������ ��Ʈ�ѷ�
public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float jumpForce = 680.0f;
    float walkForce = 30.0f;

    float maxWalkSpeed = 2.0f;

    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // EnterŰ ������ ��� ����
        if (Input.GetKeyDown(KeyCode.Return))
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        // �̵� ���⿡ ���� �̹��� ����
        int key = 0;
        if (Input.GetKey(KeyCode.D)) key = 1;
        if (Input.GetKey(KeyCode.S)) key = -1;

        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        if (key != 0)
            transform.localScale = new Vector3(key, 1, 1);
    }
}
