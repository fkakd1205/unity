using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game2의 마스크 Generator
public class MaskGenerator : MonoBehaviour
{
    public GameObject dropMaskPrefab;
    private float span = 2.5f;  // 2.5초마다 마스크 생성
    private float delta = 0;
    private int maskScale = 0;

    void Update()
    {
        this.delta += Time.deltaTime;

        // 3초마다 마스크 떨어지도록
        if (this.delta > this.span)
        {
            delta = 0;

            // 마스크 오브젝트 1개 생성
            GameObject createMask = Instantiate(dropMaskPrefab) as GameObject;
            GameObject.Find("mask_drop").GetComponent<AudioSource>().Play();  // 마스크 떨어지는 효과음

            createMask.transform.position = new Vector3(0, 5.0f, -0.1f);   // 가운데에서 마스크 떨어지도록 배치

            maskScale = Random.Range(8, 20);    // 떨어지는 마스크 사이즈 랜덤하게
            createMask.transform.localScale = new Vector3(maskScale, maskScale, 1); // 떨어지는 마스크 크기 변경

            //Debug.Log("마스크 떨어진다!");
        }
    }
}
