using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item2Generator : MonoBehaviour
{
    public GameObject ItemPrefab;
    float span = 7.0f;  // 7초마다 아이템 생성
    float delta = 0;
    float[] itemPos = { -2.5f, -0.875f, 0.75f, 2.375f, 4.0f };    // 아이템 생성 y위치

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

            float itemPosX = Random.Range(-4, 4)*2; // -8, -6, -4, -2, 0, 2, 4, 6, 8 로 x position 지정. (x좌표는 stage1과 동일하므로)
            float itemPosY = itemPos[Random.Range(0, 5)];   // 4.0, 2.375, 0.75, -0.875, -2.5로 y position 지정

            createItem.transform.position = new Vector3(itemPosX, itemPosY, 0);   // 랜덤한 위치로 아이템 배치
            Debug.Log("아이템 발견!");
        }
    }
}
