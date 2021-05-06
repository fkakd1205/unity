using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game3�� ��ħ Controller
public class Cough3Controller : MonoBehaviour
{
    private float coughSpeed = -0.04f;  // ��ħ �ӵ�

    void Update()
    {
        // ������� �̵�
        transform.Translate(0, coughSpeed, 0);

        // ��ħ�� x��ǥ�� ���� �� �� ���ʱ��� �����ϸ� ����
        if (transform.position.x < -12.0f)
        {
            Destroy(gameObject);
        }
    }

    // ��ħ�� cat�� �浹���� ��� ��ħ ����.
    void OnCollisionEnter2D(Collision2D other)
    {
        //Debug.Log("ħ ����!! ���� -1");

        // Player ȭ�� �Ҹ�
        GameObject.Find("player_angry").GetComponent<AudioSource>().Play();

        // ���� -1
        GameObject director = GameObject.Find("Game3Director");
        director.GetComponent<Game3Director>().DecreaseLife();

        Destroy(gameObject);
    }
}
