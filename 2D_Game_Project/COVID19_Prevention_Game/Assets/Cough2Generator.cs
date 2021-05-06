using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cough2Generator : MonoBehaviour
{
    public GameObject coughPrefab;
    public GameObject[] maskPrefabNum;
    private int[] maskControl = null; // 사람들의 마스크를 제어하기 위해
    float span = 3.0f;  // 3초마다 기침 생성
    float delta = 0;
    private int coughSize;
    private float[] peoplePos = {-2.5f, -0.875f, 0.75f, 2.375f, 4.0f};    // 사람들의 y 위치 좌표

    // 기침 효과음
    AudioSource female_cough;
    AudioSource male_cough;

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
                randArray[i] = Random.Range(min, max);    // 랜덤한 위치 생성
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

            // 마스크의 위치와 크기를 변경
            maskPrefabNum[i].transform.Translate(0, -0.1f, 0);
            maskPrefabNum[i].transform.localScale = new Vector3(10, 2, 1);
        }
    }

    void playSound(string sound)
    {
        // 기침 효과음 실행
        GameObject.Find(sound).GetComponent<AudioSource>().Play();
    }

    void Update()
    {
        this.delta += Time.deltaTime;

        // 3.5초마다 기침 발사
        if (this.delta > this.span)
        {
            this.delta = 0;

            playSound("female_cough");  // 주변 여성 기침
            playSound("male_cough");    // 주변 남성 기침

            // 마스크 내린 사람들 다시 올려주기, y스케일 원래대로
            for (int i = 0; i < coughSize; i++)
            {
                maskPrefabNum[i].transform.Translate(0, 0.07f, 0);
                maskPrefabNum[i].transform.localScale = new Vector3(10, 7, 1);
            }

            // 기침 개수 3 ~ 5 랜덤하게. 최대 5개까지 가능. 한 줄에 사람이 5명이므로
            coughSize = Random.Range(3, 6);

            // 기침 오브젝트 생성
            GameObject[] coughShot = new GameObject[coughSize];
            // 사람들의 마스크도 컨트롤하기 위한 배열 생성
            maskControl = new int[coughSize];

            for(int i = 0; i < coughSize; i++)
            {
                coughShot[i] = Instantiate(coughPrefab) as GameObject;  // 기침 오브젝트 생성
            }

            // 랜덤한 사람의 y축 좌표를 구하기 위해 프리팹 coughSize만큼 생성
            // 여기서 최대 인원은 peoplePos.Length로 구한다.
            int[] shotArray = getRandomInt(coughSize, 0, peoplePos.Length);

            float[] shot = new float[coughSize];     // 랜덤한 위치의 프리팹 coughSize만큼 생성

            // peoplePos[0] ~ peoplePos[4] 의 값이 shot배열에 들어간다
            for (int i = 0; i < coughSize; i++)
                shot[i] = peoplePos[shotArray[i]];

            int rightShot = Random.Range(0, coughSize-1);    // 몇개의 기침이 오른쪽 사람들에게서 발사될 것인지. (모두 오른쪽에서 나오는 기침은 피할 수 없으므로 coughSize-1) 최소 한개는 왼쪽에서 나옴.

            // 기침 발사
            for (int i = 0; i < coughSize; i++)
            {

                // 180도 회전해 오른쪽에서 발사되는 기침
                if (i <= rightShot)
                {
                    coughShot[i].transform.Rotate(0, 0, 180);
                    coughShot[i].transform.position = new Vector2(8.5f, shot[i]);    // 기침이 발사되는 위치

                    // 오른쪽의 사람들 중 어떤 사람의 마스크가 제어되는지 지정
                    if (shot[i] == peoplePos[4]) maskControl[i] = 5;
                    else if (shot[i] == peoplePos[3]) maskControl[i] = 6;
                    else if (shot[i] == peoplePos[2]) maskControl[i] = 7;
                    else if (shot[i] == peoplePos[1]) maskControl[i] = 8;
                    else maskControl[i] = 10;   // 10은 오른쪽 맨아래 사람

                    continue;
                }

                // 왼쪽에서 발사되는 기침
                coughShot[i].transform.position = new Vector2(-8.5f, shot[i]);   // 기침이 발사되는 위치

                // 왼쪽의 사람들 중 어떤 사람의 마스크가 제어되는지 지정
                if (shot[i] == peoplePos[4]) maskControl[i] = 1;
                else if (shot[i] == peoplePos[3]) maskControl[i] = 2;
                else if (shot[i] == peoplePos[2]) maskControl[i] = 3;
                else if (shot[i] == peoplePos[1]) maskControl[i] = 4;
                else maskControl[i] = 9;    // 9번은 왼쪽 맨아래 사람
            }

            // 마스크 제어
            peopleMaskControl(maskControl, coughSize);

            Debug.Log("에취!");
        }
    }
}
