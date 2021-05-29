using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;

    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
    }

    //public 이므로 다른 class에서 접근 가능
    public void DecreaseHp()
    {
        //hpGauge GameObject에서 UI<Image> 요소를 얻어서 속성 fillAmount 변수를 감소시킨다.(매 update마다)
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

void Update()
    {
        
    }
}
