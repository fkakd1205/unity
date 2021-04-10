using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoughGenerator : MonoBehaviour
{
    public GameObject coughPrefab;
    float span = 4.0f;  //4초마다 coughShot1, 2 생성
    float delta = 0;

    void Start()
    {

    }

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;

            // 기침 오브젝트 2개 생성
            GameObject coughShot1 = Instantiate(coughPrefab) as GameObject; // 왼쪽 사람들이 발사하는 침
            GameObject coughShot2 = Instantiate(coughPrefab) as GameObject; // 오른쪽 사람들이 발사하는 침
            coughShot2.transform.Rotate(0, 0, 180); // 기침2는 180도 회전해 오른쪽에서 발사되도록 함

            //Random하게 프리팹 생성
            int shot1 = Random.Range(-4, 4);
            int shot2 = Random.Range(-4, 4);

            // 사람들 얼굴에서 침이 발사되는 것처럼 보이기 위해서 y 좌표는 -4, -2, 0, 2, 4 가 적당하기 때문에 좌표변경
            if (shot1 % 2 != 0)
            {
                if (shot1 > 0) shot1++;
                else shot1--;
            }

            if (shot2 % 2 != 0)
            {
                if (shot2 > 0) shot2++;
                else shot2--;
            }

            coughShot1.transform.position = new Vector3(-8.5f, shot1, 0);   // 왼쪽 사람들 중 한 명이 침 발사
            coughShot2.transform.position = new Vector3(8.5f, shot2, 0);   // 오른쪽 사람들 중 한 명이 침 발사

            Debug.Log("침 발사!");
        }
    }
}
