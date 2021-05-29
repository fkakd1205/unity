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

    //public �̹Ƿ� �ٸ� class���� ���� ����
    public void DecreaseHp()
    {
        //hpGauge GameObject���� UI<Image> ��Ҹ� �� �Ӽ� fillAmount ������ ���ҽ�Ų��.(�� update����)
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

    public void IncreaseHp()
    {
        //hpGauge GameObject���� UI<Image> ��Ҹ� �� �Ӽ� fillAmount ������ ������Ų��.
        this.hpGauge.GetComponent<Image>().fillAmount += 0.1f;
    }

    public void resetHp()
    {
        //hpGauge GameObject���� UI<Image> ��Ҹ� �� �Ӽ� fillAmount ������ 1�� ��ȯ.-> full�� ��ȯ.
        this.hpGauge.GetComponent<Image>().fillAmount = 1f;
    }


    void Update()
    {
        //player�� yellowcat���� �Ÿ�
        Vector2 p1 = this.player.transform.position;    //�÷��̾� �߽� ��ǥ
        Vector2 p2 = this.yellowcat.transform.position;    //yellowcat �߽� ��ǥ
        Vector2 dir = p1 - p2;

        float d = dir.magnitude;

        this.distance.GetComponent<Text>().text = "Yellow Cat���� �Ÿ��� " + d.ToString("F2") + "m";
    }
}
