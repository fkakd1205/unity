using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    float span = 3.0f;  // ������ ���� �� ���� �ð� ���� ����
    float delta = 0;

    void Start()
    {
        
    }

    void Update()
    {
        this.delta += Time.deltaTime;

        // ������ ���� �� 3�� ������ ����
        if (this.delta > this.span)
        {
            Destroy(gameObject);
        }
    }

    // �������� player�� �浹���� ��� ������ ����.
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("������ ȹ��!! ȸ�� +10");
        Destroy(gameObject);
    }
}
