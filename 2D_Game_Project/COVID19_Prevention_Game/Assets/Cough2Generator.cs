using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cough2Generator : MonoBehaviour
{
    public GameObject coughPrefab;
    public GameObject[] maskPrefabNum;
    private int[] maskControl = null; // ������� ����ũ�� �����ϱ� ����
    float span = 3.0f;  // 3�ʸ��� ��ħ ����
    float delta = 0;
    private int coughSize;
    private float[] peoplePos = {-2.5f, -0.875f, 0.75f, 2.375f, 4.0f};    // ������� y ��ġ ��ǥ

    // ��ħ ȿ����
    AudioSource female_cough;
    AudioSource male_cough;

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
                randArray[i] = Random.Range(min, max);    // ������ ��ġ ����
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

            // ����ũ�� ��ġ�� ũ�⸦ ����
            maskPrefabNum[i].transform.Translate(0, -0.1f, 0);
            maskPrefabNum[i].transform.localScale = new Vector3(10, 2, 1);
        }
    }

    void playSound(string sound)
    {
        // ��ħ ȿ���� ����
        GameObject.Find(sound).GetComponent<AudioSource>().Play();
    }

    void Update()
    {
        this.delta += Time.deltaTime;

        // 3.5�ʸ��� ��ħ �߻�
        if (this.delta > this.span)
        {
            this.delta = 0;

            playSound("female_cough");  // �ֺ� ���� ��ħ
            playSound("male_cough");    // �ֺ� ���� ��ħ

            // ����ũ ���� ����� �ٽ� �÷��ֱ�, y������ �������
            for (int i = 0; i < coughSize; i++)
            {
                maskPrefabNum[i].transform.Translate(0, 0.07f, 0);
                maskPrefabNum[i].transform.localScale = new Vector3(10, 7, 1);
            }

            // ��ħ ���� 3 ~ 5 �����ϰ�. �ִ� 5������ ����. �� �ٿ� ����� 5���̹Ƿ�
            coughSize = Random.Range(3, 6);

            // ��ħ ������Ʈ ����
            GameObject[] coughShot = new GameObject[coughSize];
            // ������� ����ũ�� ��Ʈ���ϱ� ���� �迭 ����
            maskControl = new int[coughSize];

            for(int i = 0; i < coughSize; i++)
            {
                coughShot[i] = Instantiate(coughPrefab) as GameObject;  // ��ħ ������Ʈ ����
            }

            // ������ ����� y�� ��ǥ�� ���ϱ� ���� ������ coughSize��ŭ ����
            // ���⼭ �ִ� �ο��� peoplePos.Length�� ���Ѵ�.
            int[] shotArray = getRandomInt(coughSize, 0, peoplePos.Length);

            float[] shot = new float[coughSize];     // ������ ��ġ�� ������ coughSize��ŭ ����

            // peoplePos[0] ~ peoplePos[4] �� ���� shot�迭�� ����
            for (int i = 0; i < coughSize; i++)
                shot[i] = peoplePos[shotArray[i]];

            int rightShot = Random.Range(0, coughSize-1);    // ��� ��ħ�� ������ ����鿡�Լ� �߻�� ������. (��� �����ʿ��� ������ ��ħ�� ���� �� �����Ƿ� coughSize-1) �ּ� �Ѱ��� ���ʿ��� ����.

            // ��ħ �߻�
            for (int i = 0; i < coughSize; i++)
            {

                // 180�� ȸ���� �����ʿ��� �߻�Ǵ� ��ħ
                if (i <= rightShot)
                {
                    coughShot[i].transform.Rotate(0, 0, 180);
                    coughShot[i].transform.position = new Vector2(8.5f, shot[i]);    // ��ħ�� �߻�Ǵ� ��ġ

                    // �������� ����� �� � ����� ����ũ�� ����Ǵ��� ����
                    if (shot[i] == peoplePos[4]) maskControl[i] = 5;
                    else if (shot[i] == peoplePos[3]) maskControl[i] = 6;
                    else if (shot[i] == peoplePos[2]) maskControl[i] = 7;
                    else if (shot[i] == peoplePos[1]) maskControl[i] = 8;
                    else maskControl[i] = 10;   // 10�� ������ �ǾƷ� ���

                    continue;
                }

                // ���ʿ��� �߻�Ǵ� ��ħ
                coughShot[i].transform.position = new Vector2(-8.5f, shot[i]);   // ��ħ�� �߻�Ǵ� ��ġ

                // ������ ����� �� � ����� ����ũ�� ����Ǵ��� ����
                if (shot[i] == peoplePos[4]) maskControl[i] = 1;
                else if (shot[i] == peoplePos[3]) maskControl[i] = 2;
                else if (shot[i] == peoplePos[2]) maskControl[i] = 3;
                else if (shot[i] == peoplePos[1]) maskControl[i] = 4;
                else maskControl[i] = 9;    // 9���� ���� �ǾƷ� ���
            }

            // ����ũ ����
            peopleMaskControl(maskControl, coughSize);

            Debug.Log("����!");
        }
    }
}
