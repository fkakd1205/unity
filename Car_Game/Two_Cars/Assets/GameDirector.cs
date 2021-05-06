using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject redCar, redFlag;
    GameObject greenCar, greenFlag;
    GameObject distance;
    int rotCnt = 0; //RedFlag�� ȸ�� Ƚ��

    void Start()
    {
        //red car
        this.redCar = GameObject.Find("redCar");
        this.redFlag = GameObject.Find("redFlag");

        //green car
        this.greenCar = GameObject.Find("greenCar");
        this.greenFlag = GameObject.Find("greenFlag");

        //distance text
        this.distance = GameObject.Find("Distance");
    }

    void Update()
    {
        if ((int)(this.redFlag.transform.rotation.eulerAngles.y) == 0) rotCnt++; //RedFlag�� 360�� ȸ���� ������ üũ
        float yLength = this.greenCar.transform.position.y - this.greenFlag.transform.position.y;   // Red Car�� Red Flag ������ �Ÿ�
        float xLength = this.redFlag.transform.position.x - this.redCar.transform.position.x;   // Green Car�� Green Flag ������ �Ÿ�
        this.distance.GetComponent<Text>().text = "���ȸ�� Ƚ�� " + rotCnt + "ȸ \n Green Car ��ǥ �������� " + yLength.ToString("F2") + "m \n Red Car ��ǥ �������� " + xLength.ToString("F2") + "m";
    }
}

