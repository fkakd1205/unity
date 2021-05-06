using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject redCar, redFlag;
    GameObject greenCar, greenFlag;
    GameObject distance;
    int rotCnt = 0; //RedFlag의 회전 횟수

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
        if ((int)(this.redFlag.transform.rotation.eulerAngles.y) == 0) rotCnt++; //RedFlag가 360도 회전할 때마다 체크
        float yLength = this.greenCar.transform.position.y - this.greenFlag.transform.position.y;   // Red Car와 Red Flag 사이의 거리
        float xLength = this.redFlag.transform.position.x - this.redCar.transform.position.x;   // Green Car와 Green Flag 사이의 거리
        this.distance.GetComponent<Text>().text = "깃발회전 횟수 " + rotCnt + "회 \n Green Car 목표 지점까지 " + yLength.ToString("F2") + "m \n Red Car 목표 지점까지 " + xLength.ToString("F2") + "m";
    }
}

