using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game1 - Stage2의 백신 Generator
public class Vaccine2Generator : MonoBehaviour
{
    public GameObject vaccinePrefab;
    private float span = 15.0f;  // 15초마다 백신 생성
    private float delta = 0;
    private float[] itemPos = { -2.5f, -0.875f, 0.75f, 2.375f, 4.0f };    // 백신 생성 y위치

    void Update()
    {
        delta += Time.deltaTime;

        // 3.5초마다 기침 발사
        if (delta > span)
        {
            delta = 0;

            // 아이템 오브젝트 1개 생성
            GameObject createVaccine = Instantiate(vaccinePrefab) as GameObject;
            GameObject.Find("item_create").GetComponent<AudioSource>().Play();  // 아이템 생성 효과음

            float vaccinePosX = Random.Range(-4, 5) * 2; // -8, -6, -4, -2, 0, 2, 4, 6, 8 로 x position 지정. (x좌표는 stage1과 동일하므로)
            float vaccinePosY = itemPos[Random.Range(0, 5)];   // -4, -2, 0, 2, 4 로 y position 지정

            createVaccine.transform.position = new Vector3(vaccinePosX, vaccinePosY, 0);   // 랜덤한 위치로 아이템 배치
            //Debug.Log("백신 발견!");
        }
    }
}
