using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    float delta = 0;
    float zoomTime = 60.0f;  // 60초 후에 카메라 이동
    bool zoomFlag = false;

    void Start()
    {
    }

    void ZoomIn()
    {
        transform.GetComponent<Camera>().orthographicSize = 4.32f;
        transform.Translate(0, 0.3f, 0);

    }

        void Update()
    {
        this.delta += Time.deltaTime;

        // 60초 후 카메라 이동
        if (this.delta >= zoomTime && zoomFlag == false)
        {
            this.delta = 0;
            zoomFlag = true;

            // 카메라 이동 -> 줌인
            ZoomIn();
        }
    }
}
