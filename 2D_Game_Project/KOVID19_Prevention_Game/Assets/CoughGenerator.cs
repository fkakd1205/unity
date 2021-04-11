using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoughGenerator : MonoBehaviour
{
    public GameObject coughPrefab;
    float span = 3.0f;  // 3초마다 기침 생성
    float delta = 0;

    void Start()
    {

    }

    // 랜덤한 프리팹 coughSize개 생성
    int[] getRandomInt(int coughSize, int min, int max)
    {
        int[] randArray = new int[coughSize];
        bool isSame;

        for (int i = 0; i < coughSize; i++)
        {
            while (true)
            {
                randArray[i] = Random.Range(min, max) * 2;    // 사람들 얼굴에서 침이 발사되는 것처럼 보이기 위해서 y좌표는 -4, -2, 0, 2, 4가 적당하기 때문에 좌표 변경
                isSame = false;

                for (int j = 0; j < i; j++)
                {
                    if (randArray[j] == randArray[i])
                    {
                        isSame = true;
                        break;
                    }
                }
                if (!isSame) break;
            }
        }

        return randArray;
    }

    void Update()
    {
        this.delta += Time.deltaTime;

        // 3.5초마다 기침 발사
        if (this.delta > this.span)
        {
            this.delta = 0;

            // 기침 개수 3~5 랜덤하게
            int coughSize = Random.Range(3, 5);

            // 기침 오브젝트 생성
            GameObject[] coughShot = new GameObject[coughSize];

            for(int i = 0; i < coughSize; i++)
            {
                coughShot[i] = Instantiate(coughPrefab) as GameObject;  // 기침 오브젝트 생성
            }

            int[] shot = getRandomInt(coughSize, -2, 2);    // 랜덤한 프리팹 coughSize만큼 생성

            int rightShot = Random.Range(0, 2);    // 몇개의 기침이 오른쪽 사람들에게서 발사될 것인지

            // 세사람이 기침 발사
            for(int i = 0; i < coughSize; i++)
            {

                // 180도 회전해 오른쪽에서 발사되는 기침.
                if (i <= rightShot)
                {
                    coughShot[i].transform.Rotate(0, 0, 180);
                    coughShot[i].transform.position = new Vector3(8.5f, shot[i], 0);    // 기침이 발사되는 위치
                    continue;
                }

                coughShot[i].transform.position = new Vector3(-8.5f, shot[i], 0);   // 기침이 발사되는 위치
            }

            Debug.Log("에취!");
        }
    }
}
