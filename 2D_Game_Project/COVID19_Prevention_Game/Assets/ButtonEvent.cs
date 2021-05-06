using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // LoadScene�� ����ϱ� ����

// ��ư �̺�Ʈ ��ũ��Ʈ
public class ButtonEvent : MonoBehaviour
{
    // Game1�� Stage ����ȭ������ �̵�
    public void OnClickGame1_Sub()
    {
        SceneManager.LoadScene("Game1_SubScene");
    }

    // Game1_Stage1���� �̵�
    public void OnClickGame1_Stage1()
    {
        SceneManager.LoadScene("Game1_Stage1Scene");
    }

    // Game1_Stage2�� �̵�
    public void OnClickGame1_Stage2()
    {
        SceneManager.LoadScene("Game1_Stage2Scene");
    }

    // Game2�� �̵�
    public void OnClickGame2()
    {
        SceneManager.LoadScene("Game2_Scene");
    }

    // Game3���� �̵�
    public void OnClickGame3()
    {
        SceneManager.LoadScene("Game3_Scene");
    }

    // Home���� �̵�
    public void OnClickHome()
    {
        SceneManager.LoadScene("HomeScene");
    }

    // Game ����ȭ������ �̵�
    public void OnClickSelectGame()
    {
        SceneManager.LoadScene("SelectGameScene");
    }
}
