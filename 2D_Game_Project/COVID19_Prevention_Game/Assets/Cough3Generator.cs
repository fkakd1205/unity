using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Stage3의 기침 Generator
public class Cough3Generator : MonoBehaviour
{
    public GameObject cough3Prefab;
    private float span = 3.0f;  // 3초마다 기침 생성
    private float delta = 0;
    private GameObject coughPerson;  // 기침하는 사람

    // 기침 효과음
    private AudioSource female_cough;
    private AudioSource male_cough;

    // person5의 마스크 제어
    void person5MaskControl()
    {
        // 기침하는 사람의 마스크 내리기, 위치와 y스케일 변경
        coughPerson = GameObject.Find("person5_mask");

        // 마스크의 크기를 변경
        coughPerson.transform.localScale = new Vector3(10, 2, 1);
    }

    void playSound(string sound)
    {
        // 기침 효과음 실행
        GameObject.Find(sound).GetComponent<AudioSource>().Play();
    }

    void Update()
    {
        delta += Time.deltaTime;

        // 3.5초마다 기침 발사
        if (delta > span)
        {
            delta = 0;

            playSound("female_cough");  // 주변 여성 기침
            playSound("male_cough");    // 주변 남성 기침

            GameObject coughShot = Instantiate(cough3Prefab) as GameObject;  // 기침 오브젝트 생성

            // 발사되는 기침의 위치
            coughShot.transform.position = new Vector2(129.0f, -2.5f);

            // 마스크 제어
            person5MaskControl();

            //Debug.Log("에취!");
        }
    }
}
