using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game1 - Stage1의 백신 Generator
public class VaccineGenerator : MonoBehaviour
{
    public GameObject vaccinePrefab;
    private float span = 15.0f;  // 15초마다 아이템 생성
    private float delta = 0;

    void Update()
    {
        this.delta += Time.deltaTime;

        // 3.5초마다 기침 발사
        if (this.delta > this.span)
        {
            delta = 0;

            // 아이템 오브젝트 1개 생성
            GameObject createVaccine = Instantiate(vaccinePrefab) as GameObject;
            GameObject.Find("item_create").GetComponent<AudioSource>().Play();  // 아이템 생성 효과음

            int vaccinePosX = Random.Range(-4, 5) * 2; // -8, -6, -4, -2, 0, 2, 4, 6, 8 로 x position 지정
            int vaccinePosY = Random.Range(-1, 3) * 2;   // -4, -2, 0, 2, 4 로 y position 지정

            createVaccine.transform.position = new Vector3(vaccinePosX, vaccinePosY, 0);   // 랜덤한 위치로 아이템 배치
            //Debug.Log("백신 발견!");
        }
    }
}
