using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Stage3�� ��ħ Generator
public class Cough3Generator : MonoBehaviour
{
    public GameObject cough3Prefab;
    private float span = 3.0f;  // 3�ʸ��� ��ħ ����
    private float delta = 0;
    private GameObject coughPerson;  // ��ħ�ϴ� ���

    // ��ħ ȿ����
    private AudioSource female_cough;
    private AudioSource male_cough;

    // person5�� ����ũ ����
    void person5MaskControl()
    {
        // ��ħ�ϴ� ����� ����ũ ������, ��ġ�� y������ ����
        coughPerson = GameObject.Find("person5_mask");

        // ����ũ�� ũ�⸦ ����
        coughPerson.transform.localScale = new Vector3(10, 2, 1);
    }

    void playSound(string sound)
    {
        // ��ħ ȿ���� ����
        GameObject.Find(sound).GetComponent<AudioSource>().Play();
    }

    void Update()
    {
        delta += Time.deltaTime;

        // 3.5�ʸ��� ��ħ �߻�
        if (delta > span)
        {
            delta = 0;

            playSound("female_cough");  // �ֺ� ���� ��ħ
            playSound("male_cough");    // �ֺ� ���� ��ħ

            GameObject coughShot = Instantiate(cough3Prefab) as GameObject;  // ��ħ ������Ʈ ����

            // �߻�Ǵ� ��ħ�� ��ġ
            coughShot.transform.position = new Vector2(129.0f, -2.5f);

            // ����ũ ����
            person5MaskControl();

            //Debug.Log("����!");
        }
    }
}
