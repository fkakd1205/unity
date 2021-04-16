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
        float coughSpeed = Random.Range(-0.02f, -0.08f);
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
        Debug.Log("ħ ����!! ������ -20");

        // ������ 20 ����
        GameObject director = GameObject.Find("GameDirector");
        director.GetComponent<GameDirector>().IncreaseGauge(0.2f);

        Destroy(gameObject);
    }
}
