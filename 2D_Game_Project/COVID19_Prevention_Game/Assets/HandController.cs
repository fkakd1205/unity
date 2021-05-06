using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game2�� �� Controller
public class HandController : MonoBehaviour
{
    private float handSpeed = 0;
    private GameObject generator;

    void Start()
    {
        generator = GameObject.Find("HandGenerator");
    }

    // ���ο� ��� ����
    void HandGenerate()
    {
        // �ӵ� 0���� ����
        handSpeed = 0;

        // �μ� ���� �� ���ο� �� �� ���� (HandGenerator.cs�� HandControll()ȣ��)
        generator.GetComponent<HandGenerator>().HandControll();
    }

    void Update()
    {
        // SpaceŰ ������ �� �̵��ϵ���
        if (Input.GetKeyDown(KeyCode.Space))
        {
            handSpeed = 0.2f;
        }

        transform.Translate(0, handSpeed, 0);

        // ����ũ�� ����� �� ���� ������ ��
        if (transform.position.x > 11.0f)
        {
            HandGenerate();
        }
    }

    // ����ũ�� ������ ����� ��
    void OnCollisionEnter(Collision other)
    {
        HandGenerate();
    }
}
