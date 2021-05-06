using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Game1 - Stage1,Stage2 카메라 Controller
public class CameraController : MonoBehaviour
{
    private float delta = 0;
    private float zoomTime = 30.0f; // 30초 후에 카메라 이동
    private GameObject player_body; // player 오브젝트
    private bool isZoomIn = false;  // 카메라 줌인 여부

    void Start()
    {
        player_body = GameObject.Find("player_body");
    }

    void ZoomInSound()
    {
        if (!isZoomIn)
        {
            GameObject.Find("zoom_in").GetComponent<AudioSource>().Play();  // 카메라 줌인 효과음
        }
    }

    void Update()
    {
        delta += Time.deltaTime;

        // 60초 후 카메라 줌인 (주변 사람들 안보이도록)
        if (delta >= zoomTime)
        {
            // 카메라 위치 변경
            transform.position = new Vector3(0, 0.2f, -10);

            // 카메라 서서히 줌인
            if (transform.GetComponent<Camera>().orthographicSize > 4.39f)
            {
                transform.GetComponent<Camera>().orthographicSize -= 0.01f;
            }

            // player크기 축소
            if(player_body.transform.localScale.x > 0.35f)
            {
                player_body.transform.localScale -= new Vector3(0.003f, 0.003f, 0);
            }

            ZoomInSound();
            isZoomIn = true;    // 줌인 여부
        }
    }
}
