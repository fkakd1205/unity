using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoughGenerator : MonoBehaviour
{
    public GameObject coughPrefab;
    public GameObject[] maskPrefabNum;
    private int[] maskControl = null; // 사람들의 마스크를 제어하기 위해
    float span = 3.0f;  // 3초마다 기침 생성
    float delta = 0;
    private int coughSize;

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
                randArray[i] = Random.Range(min, max) * 2;    // 사람들 얼굴에서 침이 발사되는 것처럼 보이기 위해서 y좌표는 -2, 0, 2, 4가 적당하기 때문에 좌표 변경
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

    void peopleMaskControl(int[] maskControl, int controlSize)
    {
        maskPrefabNum = new GameObject[controlSize];

        // 기침하는 사람들의 마스크 내리기, 위치와 y스케일 변경
        for (int i = 0; i < controlSize; i++)
        {
            maskPrefabNum[i] = GameObject.Find("person" + maskControl[i] + "_mask");
            maskPrefabNum[i].transform.Translate(0, -0.1f, 0);
            maskPrefabNum[i].transform.localScale = new Vector3(10, 2, 1);
        }
    }

    void Update()
    {
        this.delta += Time.deltaTime;

        // 3.5초마다 기침 발사
        if (this.delta > this.span)
        {
            this.delta = 0;

            // 마스크 내린 사람들 다시 올려주기, y스케일 원래대로
            for (int i = 0; i < coughSize; i++)
            {
                maskPrefabNum[i].transform.Translate(0, 0.1f, 0);
                maskPrefabNum[i].transform.localScale = new Vector3(10, 7, 1);
            }

            // 기침 개수 3~4 랜덤하게
            coughSize = Random.Range(3, 5);

            // 기침 오브젝트 생성
            GameObject[] coughShot = new GameObject[coughSize];
            // 사람들의 마스크도 컨트롤하기 위한 배열 생성
            maskControl = new int[coughSize];

            for(int i = 0; i < coughSize; i++)
            {
                coughShot[i] = Instantiate(coughPrefab) as GameObject;  // 기침 오브젝트 생성
            }

            int[] shot = getRandomInt(coughSize, -1, 3);    // 랜덤한 위치의 프리팹 coughSize만큼 생성

            int rightShot = Random.Range(0, coughSize);    // 몇개의 기침이 오른쪽 사람들에게서 발사될 것인지

            // 기침 발사
            for(int i = 0; i < coughSize; i++)
            {

                // 180도 회전해 오른쪽에서 발사되는 기침
                if (i <= rightShot)
                {
                    coughShot[i].transform.Rotate(0, 0, 180);
                    coughShot[i].transform.position = new Vector2(8.5f, shot[i]);    // 기침이 발사되는 위치

                    // 오른쪽의 사람들 중 어떤 사람의 마스크가 제어되는지 지정
                    if (shot[i] == 4) maskControl[i] = 5;
                    else if (shot[i] == 2) maskControl[i] = 6;
                    else if (shot[i] == 0) maskControl[i] = 7;
                    else maskControl[i] = 8;

                    continue;
                }

                // 왼쪽에서 발사되는 기침
                coughShot[i].transform.position = new Vector2(-8.5f, shot[i]);   // 기침이 발사되는 위치

                // 왼쪽의 사람들 중 어떤 사람의 마스크가 제어되는지 지정
                if (shot[i] == 4) maskControl[i] = 1;
                else if (shot[i] == 2) maskControl[i] = 2;
                else if (shot[i] == 0) maskControl[i] = 3;
                else maskControl[i] = 4;
            }

            // 마스크 제어
            peopleMaskControl(maskControl, coughSize);

            Debug.Log("에취!");
        }
    }
}
