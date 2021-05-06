using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // LoadScene�� ����ϱ� ����

// Game3�� ��� Controller
public class Vaccine3Controller : MonoBehaviour
{
    private int rotSpeed = 60;

    void Update()
    {
        transform.Rotate(0, 0, rotSpeed * Time.deltaTime);
    }

    // cat�� ����� ȹ�� (��Ű� cat�� �浹)
    void OnCollisionEnter2D(Collision2D other)
    {
        GameObject.Find("player_laugh").GetComponent<AudioSource>().Play(); // Player ���� �Ҹ�
        GameObject.Find("item_drink").GetComponent<AudioSource>().Play();   // ������ ȹ�� �Ҹ�

        Destroy(gameObject);

        SceneManager.LoadScene("Game3_ClearScene"); // Game3_ClearScene���� �̵�
    }
}
