using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game3�� ī�޶� Controller
public class Game3CameraController : MonoBehaviour
{
    private GameObject cat;

    void Start()
    {
        this.cat = GameObject.Find("cat");
    }

    void Update()
    {
        Vector3 catPos = this.cat.transform.position;

        // ī�޶� �̵� (cat�� ��ġ�� 0���� ũ�� 160���� ���� ���� ����)
        if(catPos.x > -7.0f && catPos.x < 165.0f)
            transform.position = new Vector3(catPos.x+5.0f, transform.position.y, transform.position.z);    // ī�޶�� cat�� x��ǥ +3�� ��ġ
    }
}
