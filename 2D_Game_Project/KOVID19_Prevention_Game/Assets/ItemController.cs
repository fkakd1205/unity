using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {

    }

    // �������� player�� �浹���� ��� ������ ����.
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("������ ȹ��!! ȸ�� +10");
        Destroy(gameObject);
    }
}
