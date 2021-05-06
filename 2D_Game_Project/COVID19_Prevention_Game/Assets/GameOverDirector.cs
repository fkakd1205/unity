using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // LoadScene을 사용하기 위해

public class GameOverDirector : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        // SubStageScene으로 이동(Stage선택화면)
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("SubStageScene");
        }
    }
}
