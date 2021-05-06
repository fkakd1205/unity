using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game1 - Stage1�� ��� Generator
public class VaccineGenerator : MonoBehaviour
{
    public GameObject vaccinePrefab;
    private float span = 15.0f;  // 15�ʸ��� ������ ����
    private float delta = 0;

    void Update()
    {
        this.delta += Time.deltaTime;

        // 3.5�ʸ��� ��ħ �߻�
        if (this.delta > this.span)
        {
            delta = 0;

            // ������ ������Ʈ 1�� ����
            GameObject createVaccine = Instantiate(vaccinePrefab) as GameObject;
            GameObject.Find("item_create").GetComponent<AudioSource>().Play();  // ������ ���� ȿ����

            int vaccinePosX = Random.Range(-4, 5) * 2; // -8, -6, -4, -2, 0, 2, 4, 6, 8 �� x position ����
            int vaccinePosY = Random.Range(-1, 3) * 2;   // -4, -2, 0, 2, 4 �� y position ����

            createVaccine.transform.position = new Vector3(vaccinePosX, vaccinePosY, 0);   // ������ ��ġ�� ������ ��ġ
            //Debug.Log("��� �߰�!");
        }
    }
}
