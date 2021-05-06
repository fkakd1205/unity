using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game1 - Stage2�� ��� Generator
public class Vaccine2Generator : MonoBehaviour
{
    public GameObject vaccinePrefab;
    private float span = 15.0f;  // 15�ʸ��� ��� ����
    private float delta = 0;
    private float[] itemPos = { -2.5f, -0.875f, 0.75f, 2.375f, 4.0f };    // ��� ���� y��ġ

    void Update()
    {
        delta += Time.deltaTime;

        // 3.5�ʸ��� ��ħ �߻�
        if (delta > span)
        {
            delta = 0;

            // ������ ������Ʈ 1�� ����
            GameObject createVaccine = Instantiate(vaccinePrefab) as GameObject;
            GameObject.Find("item_create").GetComponent<AudioSource>().Play();  // ������ ���� ȿ����

            float vaccinePosX = Random.Range(-4, 5) * 2; // -8, -6, -4, -2, 0, 2, 4, 6, 8 �� x position ����. (x��ǥ�� stage1�� �����ϹǷ�)
            float vaccinePosY = itemPos[Random.Range(0, 5)];   // -4, -2, 0, 2, 4 �� y position ����

            createVaccine.transform.position = new Vector3(vaccinePosX, vaccinePosY, 0);   // ������ ��ġ�� ������ ��ġ
            //Debug.Log("��� �߰�!");
        }
    }
}
