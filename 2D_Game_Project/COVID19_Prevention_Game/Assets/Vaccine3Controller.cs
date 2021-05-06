using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // LoadScene을 사용하기 위해

// Game3의 백신 Controller
public class Vaccine3Controller : MonoBehaviour
{
    private int rotSpeed = 60;

    void Update()
    {
        transform.Rotate(0, 0, rotSpeed * Time.deltaTime);
    }

    // cat이 백신을 획득 (백신과 cat이 충돌)
    void OnCollisionEnter2D(Collision2D other)
    {
        GameObject.Find("player_laugh").GetComponent<AudioSource>().Play(); // Player 웃는 소리
        GameObject.Find("item_drink").GetComponent<AudioSource>().Play();   // 아이템 획득 소리

        Destroy(gameObject);

        SceneManager.LoadScene("Game3_ClearScene"); // Game3_ClearScene으로 이동
    }
}
