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

    //public �̹Ƿ� �ٸ� class���� ���� ����
    public void DecreaseHp()
    {
        //hpGauge GameObject���� UI<Image> ��Ҹ� �� �Ӽ� fillAmount ������ ���ҽ�Ų��.(�� update����)
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

void Update()
    {
        
    }
}
