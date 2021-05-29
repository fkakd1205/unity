using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;
    GameObject player;
    GameObject yellowcat;
    GameObject distance;

    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
        this.player = GameObject.Find("player");
        this.yellowcat = GameObject.Find("cat");
        this.distance = GameObject.Find("distance");
    }

    //public 이므로 다른 class에서 접근 가능
    public void DecreaseHp()
    {
        //hpGauge GameObject에서 UI<Image> 요소를 얻어서 속성 fillAmount 변수를 감소시킨다.(매 update마다)
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

    public void IncreaseHp()
    {
        //hpGauge GameObject에서 UI<Image> 요소를 얻어서 속성 fillAmount 변수를 증가시킨다.
        this.hpGauge.GetComponent<Image>().fillAmount += 0.1f;
    }

    public void resetHp()
    {
        //hpGauge GameObject에서 UI<Image> 요소를 얻어서 속성 fillAmount 변수를 1로 변환.-> full로 변환.
        this.hpGauge.GetComponent<Image>().fillAmount = 1f;
    }


    void Update()
    {
        //player와 yellowcat사이 거리
        Vector2 p1 = this.player.transform.position;    //플레이어 중심 좌표
        Vector2 p2 = this.yellowcat.transform.position;    //yellowcat 중심 좌표
        Vector2 dir = p1 - p2;

        float d = dir.magnitude;

        this.distance.GetComponent<Text>().text = "Yellow Cat과의 거리는 " + d.ToString("F2") + "m";
    }
}
