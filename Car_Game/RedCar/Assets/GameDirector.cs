using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject redCar, redFlag;
    GameObject distance;

    void Start()
    {
        //red car
        this.redCar = GameObject.Find("redCar");
        this.redFlag = GameObject.Find("redFlag");

        //distance text
        this.distance = GameObject.Find("Distance");
    }

    void Update()
    {
        float xLength = this.redFlag.transform.position.x - this.redCar.transform.position.x;
        this.distance.GetComponent<Text>().text = "\n Red Car 목표 지점까지 " + xLength.ToString("F2") + "m";
    }
}

