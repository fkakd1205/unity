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

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);    // Camera.main.ScreenPointToRay �޼ҵ� ����ؼ� 2���� ��ǥ�� 3���� ��ǥ�� ����
            Vector3 worldDir = ray.direction;   // ī�޶󿡼� ���� ��ǥ�� ���ϴ� ����
            bamsongi.GetComponent<Bamsongi1Controller>().Shoot(worldDir.normalized * 2000);    // direction���Ͱ� ���� normalized������ ����Ͽ� ���̰� 1�� ���ͷ� ���� �� 2000 ����.
        }
    }
}
