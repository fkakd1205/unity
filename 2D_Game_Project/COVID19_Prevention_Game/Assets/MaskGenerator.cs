using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game2�� ����ũ Generator
public class MaskGenerator : MonoBehaviour
{
    public GameObject dropMaskPrefab;
    private float span = 2.5f;  // 2.5�ʸ��� ����ũ ����
    private float delta = 0;
    private int maskScale = 0;

    void Update()
    {
        this.delta += Time.deltaTime;

        // 3�ʸ��� ����ũ ����������
        if (this.delta > this.span)
        {
            delta = 0;

            // ����ũ ������Ʈ 1�� ����
            GameObject createMask = Instantiate(dropMaskPrefab) as GameObject;
            GameObject.Find("mask_drop").GetComponent<AudioSource>().Play();  // ����ũ �������� ȿ����

            createMask.transform.position = new Vector3(0, 5.0f, -0.1f);   // ������� ����ũ ���������� ��ġ

            maskScale = Random.Range(8, 20);    // �������� ����ũ ������ �����ϰ�
            createMask.transform.localScale = new Vector3(maskScale, maskScale, 1); // �������� ����ũ ũ�� ����

            //Debug.Log("����ũ ��������!");
        }
    }
}
