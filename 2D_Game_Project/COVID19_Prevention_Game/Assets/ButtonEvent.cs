using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // LoadScene을 사용하기 위해

public class ButtonEvent : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
    }

    // GameScene으로 이동
    public void OnClickStart()
    {
        SceneManager.LoadScene("SubStageScene");
    }

    // stage1으로 이동
    public void OnClickStage1()
    {
        SceneManager.LoadScene("GameStage1Scene");
    }

    // stage2로 이동
    public void OnClickStage2()
    {

    }
}
