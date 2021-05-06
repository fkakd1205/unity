using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // LoadScene을 사용하기 위해

// 버튼 이벤트 스크립트
public class ButtonEvent : MonoBehaviour
{
    // Game1의 Stage 선택화면으로 이동
    public void OnClickGame1_Sub()
    {
        SceneManager.LoadScene("Game1_SubScene");
    }

    // Game1_Stage1으로 이동
    public void OnClickGame1_Stage1()
    {
        SceneManager.LoadScene("Game1_Stage1Scene");
    }

    // Game1_Stage2로 이동
    public void OnClickGame1_Stage2()
    {
        SceneManager.LoadScene("Game1_Stage2Scene");
    }

    // Game2로 이동
    public void OnClickGame2()
    {
        SceneManager.LoadScene("Game2_Scene");
    }

    // Game3으로 이동
    public void OnClickGame3()
    {
        SceneManager.LoadScene("Game3_Scene");
    }

    // Home으로 이동
    public void OnClickHome()
    {
        SceneManager.LoadScene("HomeScene");
    }

    // Game 선택화면으로 이동
    public void OnClickSelectGame()
    {
        SceneManager.LoadScene("SelectGameScene");
    }
}
