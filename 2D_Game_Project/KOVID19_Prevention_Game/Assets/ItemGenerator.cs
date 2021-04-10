using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject ItemPrefab;
    float span = 5.0f;  // 5초마다 아이템 생성
    float delta = 0;
    float destroyTime = 3.0f;   // 아이템 생성 후 3초 후 아이템 사라짐
    float time = 0;

    void Start()
    {
        
    }

    void Update()
    {
        this.delta += Time.deltaTime;

        // 3.5초마다 기침 발사
        if (this.delta > this.span)
        {
            delta = 0;
            // 아이템 오브젝트 1개 생성
            GameObject createItem = Instantiate(ItemPrefab) as GameObject;

            int itemPosX = Random.Range(-4, 4) * 2; // -8, -6, -4, -2, 0, 2, 4, 6, 8 로 x position 지정
            int itemPosY = Random.Range(-2, 2) * 2;   // -4, -2, 0, 2, 4 로 y position 지정

            createItem.transform.position = new Vector3(itemPosX, itemPosY, 0);   // 랜덤한 위치로 아이템 배치
            Debug.Log("아이템 발견!");
        }
    }
}
