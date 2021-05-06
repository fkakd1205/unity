using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game3의 카메라 Controller
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

        // 카메라 이동 (cat의 위치가 0보다 크고 160보다 작을 때만 적용)
        if(catPos.x > -7.0f && catPos.x < 165.0f)
            transform.position = new Vector3(catPos.x+5.0f, transform.position.y, transform.position.z);    // 카메라는 cat의 x좌표 +3에 위치
    }
}
