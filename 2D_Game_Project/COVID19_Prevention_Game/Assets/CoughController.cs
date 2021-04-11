using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoughController : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        // ������ ���ǵ�� ��ħ �߻� 
        float coughSpeed = Random.Range(-0.01f, -0.05f);
        // ������� �̵�
        transform.Translate(0, coughSpeed, 0);

        // ��ħ�� x��ǥ�� �ݴ��� ����� x��ǥ�� ������ ��ħ ����
        if (transform.position.x < -9.0f || transform.position.x > 9.0f)
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
