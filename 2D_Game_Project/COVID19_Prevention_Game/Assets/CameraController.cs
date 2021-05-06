using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Game1 - Stage1,Stage2 ī�޶� Controller
public class CameraController : MonoBehaviour
{
    private float delta = 0;
    private float zoomTime = 30.0f; // 30�� �Ŀ� ī�޶� �̵�
    private GameObject player_body; // player ������Ʈ
    private bool isZoomIn = false;  // ī�޶� ���� ����

    void Start()
    {
        player_body = GameObject.Find("player_body");
    }

    void ZoomInSound()
    {
        if (!isZoomIn)
        {
            GameObject.Find("zoom_in").GetComponent<AudioSource>().Play();  // ī�޶� ���� ȿ����
        }
    }

    void Update()
    {
        delta += Time.deltaTime;

        // 60�� �� ī�޶� ���� (�ֺ� ����� �Ⱥ��̵���)
        if (delta >= zoomTime)
        {
            // ī�޶� ��ġ ����
            transform.position = new Vector3(0, 0.2f, -10);

            // ī�޶� ������ ����
            if (transform.GetComponent<Camera>().orthographicSize > 4.39f)
            {
                transform.GetComponent<Camera>().orthographicSize -= 0.01f;
            }

            // playerũ�� ���
            if(player_body.transform.localScale.x > 0.35f)
            {
                player_body.transform.localScale -= new Vector3(0.003f, 0.003f, 0);
            }

            ZoomInSound();
            isZoomIn = true;    // ���� ����
        }
    }
}
