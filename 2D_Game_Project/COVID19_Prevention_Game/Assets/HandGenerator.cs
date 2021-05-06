using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game2의 손 Generator
public class HandGenerator : MonoBehaviour
{
    private GameObject[] hand;
    public GameObject handPrefab;

    void Start()
    {
        hand = new GameObject[2];
        CreateHandPrefab();
    }
    
    // 양손 생성 후 배치
    void CreateHandPrefab()
    {
        for(int i = 0; i < 2; i++)
        {
            hand[i] = Instantiate(handPrefab) as GameObject;
            hand[i].transform.position = new Vector2(-8.0f, -3.7f);

            // 오른쪽 손은 재배치, 이미지 반전
            if(i == 1)
            {
                hand[i].transform.position = new Vector2(8.0f, -3.7f);
                hand[i].transform.Rotate(180, 0, 0);
            }
        }
    }

    // HandControll.cs에서 호출됨
    public void HandControll()
    {
        Destroy(hand[0]);   // 왼손 삭제
        Destroy(hand[1]);   // 오른손 삭제
        CreateHandPrefab(); // 양손 재 생성
    }
}
