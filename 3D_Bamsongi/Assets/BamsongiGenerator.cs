using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bamsongi = Instantiate(bamsongiPrefab) as GameObject;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);    // Camera.main.ScreenPointToRay 메소드 사용해서 2차원 좌표를 3차원 좌표로 변경
            Vector3 worldDir = ray.direction;   // 카메라에서 탬한 좌표로 향하는 벡터
            bamsongi.GetComponent<Bamsongi1Controller>().Shoot(worldDir.normalized * 2000);    // direction벡터가 가진 normalized변수를 사용하여 길이가 1인 벡터로 만들어서 힘 2000 설정.
        }
    }
}
