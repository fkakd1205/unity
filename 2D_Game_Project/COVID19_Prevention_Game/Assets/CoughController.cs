using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game1 - Stage1, Stage2�� ��ħ Controller
public class CoughController : MonoBehaviour
{
    private float coughSpeed;

    void Update()
    {
        // ������ ���ǵ�� ��ħ �߻� 
        coughSpeed = Random.Range(-0.02f, -0.1f);

        // ������� �̵�
        transform.Translate(0, coughSpeed, 0);

        // ��ħ�� x��ǥ�� �ݴ��� ����� x��ǥ�� ������ ��ħ ����
        if (transform.position.x < -9.0f || transform.position.x > 9.0f)
        {
            Destroy(gameObject);
        }
    }

    // ��ħ�� player�� �浹���� ���
    void OnCollisionEnter2D(Collision2D other)
    {
        //Debug.Log("ħ ����!! ������ +30");

        // Player ȭ�� �Ҹ�
        GameObject.Find("player_angry").GetComponent<AudioSource>().Play();

        // ������ 30 ����
        GameObject director = GameObject.Find("GameDirector");
        director.GetComponent<GameDirector>().IncreaseGauge(0.3f);

        Destroy(gameObject);    // ��ħ ����
    }
}
