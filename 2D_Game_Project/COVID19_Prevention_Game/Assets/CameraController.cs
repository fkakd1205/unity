using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    float delta = 0;
    float zoomTime = 60.0f;  // 60�� �Ŀ� ī�޶� �̵�
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

        // 60�� �� ī�޶� �̵�
        if (this.delta >= zoomTime && zoomFlag == false)
        {
            this.delta = 0;
            zoomFlag = true;

            // ī�޶� �̵� -> ����
            ZoomIn();
        }
    }
}
