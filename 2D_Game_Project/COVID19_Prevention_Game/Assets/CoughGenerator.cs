using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoughGenerator : MonoBehaviour
{
    public GameObject coughPrefab;
    public GameObject[] maskPrefabNum;
    private int[] maskControl = null; // ������� ����ũ�� �����ϱ� ����
    float span = 3.0f;  // 3�ʸ��� ��ħ ����
    float delta = 0;
    private int coughSize;

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
                randArray[i] = Random.Range(min, max) * 2;    // ����� �󱼿��� ħ�� �߻�Ǵ� ��ó�� ���̱� ���ؼ� y��ǥ�� -2, 0, 2, 4�� �����ϱ� ������ ��ǥ ����
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

        // ��ħ�ϴ� ������� ����ũ ������, ��ġ�� y������ ����
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

        // 3.5�ʸ��� ��ħ �߻�
        if (this.delta > this.span)
        {
            this.delta = 0;

            // ����ũ ���� ����� �ٽ� �÷��ֱ�, y������ �������
            for (int i = 0; i < coughSize; i++)
            {
                maskPrefabNum[i].transform.Translate(0, 0.1f, 0);
                maskPrefabNum[i].transform.localScale = new Vector3(10, 7, 1);
            }

            // ��ħ ���� 3~4 �����ϰ�
            coughSize = Random.Range(3, 5);

            // ��ħ ������Ʈ ����
            GameObject[] coughShot = new GameObject[coughSize];
            // ������� ����ũ�� ��Ʈ���ϱ� ���� �迭 ����
            maskControl = new int[coughSize];

            for(int i = 0; i < coughSize; i++)
            {
                coughShot[i] = Instantiate(coughPrefab) as GameObject;  // ��ħ ������Ʈ ����
            }

            int[] shot = getRandomInt(coughSize, -1, 3);    // ������ ��ġ�� ������ coughSize��ŭ ����

            int rightShot = Random.Range(0, coughSize);    // ��� ��ħ�� ������ ����鿡�Լ� �߻�� ������

            // ��ħ �߻�
            for(int i = 0; i < coughSize; i++)
            {

                // 180�� ȸ���� �����ʿ��� �߻�Ǵ� ��ħ
                if (i <= rightShot)
                {
                    coughShot[i].transform.Rotate(0, 0, 180);
                    coughShot[i].transform.position = new Vector2(8.5f, shot[i]);    // ��ħ�� �߻�Ǵ� ��ġ

                    // �������� ����� �� � ����� ����ũ�� ����Ǵ��� ����
                    if (shot[i] == 4) maskControl[i] = 5;
                    else if (shot[i] == 2) maskControl[i] = 6;
                    else if (shot[i] == 0) maskControl[i] = 7;
                    else maskControl[i] = 8;

                    continue;
                }

                // ���ʿ��� �߻�Ǵ� ��ħ
                coughShot[i].transform.position = new Vector2(-8.5f, shot[i]);   // ��ħ�� �߻�Ǵ� ��ġ

                // ������ ����� �� � ����� ����ũ�� ����Ǵ��� ����
                if (shot[i] == 4) maskControl[i] = 1;
                else if (shot[i] == 2) maskControl[i] = 2;
                else if (shot[i] == 0) maskControl[i] = 3;
                else maskControl[i] = 4;
            }

            // ����ũ ����
            peopleMaskControl(maskControl, coughSize);

            Debug.Log("����!");
        }
    }
}
