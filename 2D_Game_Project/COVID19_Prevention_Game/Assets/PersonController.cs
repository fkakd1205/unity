using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game3�� ����� Controller
public class PersonController : MonoBehaviour
{

    // cat�� ������ �ε����� ��
    void OnCollisionEnter2D(Collision2D other)
    {
        //Debug.Log("������ �浹! ���� -1");

        // Player ȭ�� �Ҹ�
        GameObject.Find("player_angry").GetComponent<AudioSource>().Play();

        // ���� -1
        GameObject director = GameObject.Find("Game3Director");
        director.GetComponent<Game3Director>().DecreaseLife();
    }
}
