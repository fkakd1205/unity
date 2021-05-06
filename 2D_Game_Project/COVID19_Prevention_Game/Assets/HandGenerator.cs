using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game2�� �� Generator
public class HandGenerator : MonoBehaviour
{
    private GameObject[] hand;
    public GameObject handPrefab;

    void Start()
    {
        hand = new GameObject[2];
        CreateHandPrefab();
    }
    
    // ��� ���� �� ��ġ
    void CreateHandPrefab()
    {
        for(int i = 0; i < 2; i++)
        {
            hand[i] = Instantiate(handPrefab) as GameObject;
            hand[i].transform.position = new Vector2(-8.0f, -3.7f);

            // ������ ���� ���ġ, �̹��� ����
            if(i == 1)
            {
                hand[i].transform.position = new Vector2(8.0f, -3.7f);
                hand[i].transform.Rotate(180, 0, 0);
            }
        }
    }

    // HandControll.cs���� ȣ���
    public void HandControll()
    {
        Destroy(hand[0]);   // �޼� ����
        Destroy(hand[1]);   // ������ ����
        CreateHandPrefab(); // ��� �� ����
    }
}
