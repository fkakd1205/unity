using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // LoadScene�� ����ϱ� ����

public class GameOverDirector : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        // SubStageScene���� �̵�(Stage����ȭ��)
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("SubStageScene");
        }
    }
}
