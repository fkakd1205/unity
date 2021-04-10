using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoughGenerator : MonoBehaviour
{
    public GameObject coughPrefab;
    float span = 4.0f;  //4�ʸ��� coughShot1, 2 ����
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

            // ��ħ ������Ʈ 2�� ����
            GameObject coughShot1 = Instantiate(coughPrefab) as GameObject; // ���� ������� �߻��ϴ� ħ
            GameObject coughShot2 = Instantiate(coughPrefab) as GameObject; // ������ ������� �߻��ϴ� ħ
            coughShot2.transform.Rotate(0, 0, 180); // ��ħ2�� 180�� ȸ���� �����ʿ��� �߻�ǵ��� ��

            //Random�ϰ� ������ ����
            int shot1 = Random.Range(-4, 4);
            int shot2 = Random.Range(-4, 4);

            // ����� �󱼿��� ħ�� �߻�Ǵ� ��ó�� ���̱� ���ؼ� y ��ǥ�� -4, -2, 0, 2, 4 �� �����ϱ� ������ ��ǥ����
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

            coughShot1.transform.position = new Vector3(-8.5f, shot1, 0);   // ���� ����� �� �� ���� ħ �߻�
            coughShot2.transform.position = new Vector3(8.5f, shot2, 0);   // ������ ����� �� �� ���� ħ �߻�

            Debug.Log("ħ �߻�!");
        }
    }
}
