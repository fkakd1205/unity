using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoughGenerator : MonoBehaviour
{
    public GameObject coughPrefab;
    float span = 3.0f;  // 3�ʸ��� ��ħ ����
    float delta = 0;

    void Start()
    {

    }

    // ������ ������ coughSize�� ����
    int[] getRandomInt(int coughSize, int min, int max)
    {
        int[] randArray = new int[coughSize];
        bool isSame;

        for (int i = 0; i < coughSize; i++)
        {
            while (true)
            {
                randArray[i] = Random.Range(min, max) * 2;    // ����� �󱼿��� ħ�� �߻�Ǵ� ��ó�� ���̱� ���ؼ� y��ǥ�� -4, -2, 0, 2, 4�� �����ϱ� ������ ��ǥ ����
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

        // 3.5�ʸ��� ��ħ �߻�
        if (this.delta > this.span)
        {
            this.delta = 0;

            // ��ħ ���� 3~5 �����ϰ�
            int coughSize = Random.Range(3, 5);

            // ��ħ ������Ʈ ����
            GameObject[] coughShot = new GameObject[coughSize];

            for(int i = 0; i < coughSize; i++)
            {
                coughShot[i] = Instantiate(coughPrefab) as GameObject;  // ��ħ ������Ʈ ����
            }

            int[] shot = getRandomInt(coughSize, -2, 2);    // ������ ������ coughSize��ŭ ����

            int rightShot = Random.Range(0, 2);    // ��� ��ħ�� ������ ����鿡�Լ� �߻�� ������

            // ������� ��ħ �߻�
            for(int i = 0; i < coughSize; i++)
            {

                // 180�� ȸ���� �����ʿ��� �߻�Ǵ� ��ħ.
                if (i <= rightShot)
                {
                    coughShot[i].transform.Rotate(0, 0, 180);
                    coughShot[i].transform.position = new Vector3(8.5f, shot[i], 0);    // ��ħ�� �߻�Ǵ� ��ġ
                    continue;
                }

                coughShot[i].transform.position = new Vector3(-8.5f, shot[i], 0);   // ��ħ�� �߻�Ǵ� ��ġ
            }

            Debug.Log("����!");
        }
    }
}
