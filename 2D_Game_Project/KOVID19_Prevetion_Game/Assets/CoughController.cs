using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoughController : MonoBehaviour
{
    int coughDirection;

    void Start()
    {

    }

    void Update()
    {
        // �����Ӹ��� ������� ��ħ �̵�
        transform.Translate(0, -0.03f, 0);

        //
        if(transform.position.x < -9.0f || transform.position.x > 9.0f)
        {
            Destroy(gameObject);
        }
    }

    // ��ħ�� player�� �浹���� ��� ��ħ ����.
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("ħ ����!! ������ -10");
        Destroy(gameObject);
    }
}
