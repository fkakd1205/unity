using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game2�� ����ũ Controller
public class MaskController : MonoBehaviour
{
    private GameObject director;
    private bool catchFlag = false; // ����ũ ���� ����

    void Start()
    {
        director = GameObject.Find("Game2Director");
    }

    void Update()
    {
        // ����ũ�� �ٴڿ� ������ ���
        if(this.transform.position.y <= -4.5f)
        {
            //Debug.Log("����ũ ���ƴ�");

            // ���� ���� �� ������ ���
            if (!catchFlag)
            {
                GameObject.Find("player_angry").GetComponent<AudioSource>().Play();

                // ���� -1
                director.GetComponent<Game2Director>().DecreaseLife();
            }

            // ����ũ ����
            Destroy(gameObject);
        }
    }

    // ����ũ�� ������ ����� �� (�����հ� ����� ��)
    void OnCollisionEnter(Collision other)
    {
        //Debug.Log("����ũ ��Ҵ�");

        // Player ���� �Ҹ�
        GameObject.Find("player_laugh").GetComponent<AudioSource>().Play();

        // ���� +1
        director.GetComponent<Game2Director>().IncreaseLife();

        catchFlag = true;
    }
}
