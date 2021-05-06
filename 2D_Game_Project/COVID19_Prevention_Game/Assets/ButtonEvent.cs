using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // LoadScene�� ����ϱ� ����

public class ButtonEvent : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
    }

    // GameScene���� �̵�
    public void OnClickStart()
    {
        SceneManager.LoadScene("SubStageScene");
    }

    // stage1���� �̵�
    public void OnClickStage1()
    {
        SceneManager.LoadScene("GameStage1Scene");
    }

    // stage2�� �̵�
    public void OnClickStage2()
    {

    }
}
