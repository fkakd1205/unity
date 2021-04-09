using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRouletteController : MonoBehaviour
{
    float rotSpeed = 0;
    bool rotFlag = false;   // ȸ�� ���� (ȸ�� - true, ȸ��X - false)

    void Start()
    {
    }

    // �귿�� ����� ����ϴ� �Լ�
    void rouletteResult()
    {
        if (this.rotFlag == true)    // �귿�� ������ ���� ��� ���
        {
            float objAngle = transform.rotation.eulerAngles.z; // left_roulette�� zȸ�� ���� (0���� 360������ ���� ���)
            string rouletteResult = "";

            // �귿�� z�� ������ ���� ��� ���
            if (objAngle > 30 && objAngle <= 90) rouletteResult += "����";
            else if (objAngle > 90 && objAngle <= 150) rouletteResult += "�ſ쳪��";
            else if (objAngle > 150 && objAngle <= 210) rouletteResult += "����";
            else if (objAngle > 211 && objAngle <= 270) rouletteResult += "����";
            else if (objAngle > 271 && objAngle <= 330) rouletteResult += "����";
            else rouletteResult += "����";

            Debug.Log("Left Roulette�� ��� : ���" + rouletteResult);

            this.rotFlag = false;   // ��� ��� �� ȸ�� ���� false�� ����
        }
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){   // ���콺 ���� ��ư�� ������ ��
            this.rotSpeed = 10;
            this.rotFlag = true;    // ȸ�� ���� true�� ����
        }

        this.rotSpeed *= 0.96f;

        transform.Rotate(0, 0, this.rotSpeed);

        // ������� �ӵ��� ���ҵǸ� ������ ���ߵ��� ����.
        if(this.rotSpeed < 0.1)
        {
            this.rotSpeed = 0;
            rouletteResult();   // �귿�� ��� ���
        }

    }


}
