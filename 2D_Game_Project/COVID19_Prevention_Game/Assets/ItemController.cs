using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game1 - Stage1�� ������ Controller
public class ItemController : MonoBehaviour
{
    private float span = 3.0f;  // ������ ���� �� ���� �ð� ���� ����
    private float delta = 0;

    void Update()
    {
        delta += Time.deltaTime;

        // ������ ���� �� 3�� ������ ����
        if (delta > span)
        {
            Destroy(gameObject);
        }

        // ������ Fade In
        if(delta < span)
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, delta);
        }
    }

    // �������� player�� �浹���� ��� ������ ����.
    void OnCollisionEnter2D(Collision2D other)
    {
        //Debug.Log("������ ȹ��!! ȸ�� +10");
        
        // Player ���� �Ҹ�
        GameObject.Find("player_laugh").GetComponent<AudioSource>().Play();

        // ������ 10 ����
        GameObject director = GameObject.Find("GameDirector");
        director.GetComponent<GameDirector>().DecreaseGauge(0.1f);

        // ������ ����
        Destroy(gameObject);
    }
}
