using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game1 - Stage2�� ������ Generator
public class Item2Generator : MonoBehaviour
{
    public GameObject ItemPrefab;
    private float span = 7.0f;  // 7�ʸ��� ������ ����
    private float delta = 0;
    private float[] itemPos = { -2.5f, -0.875f, 0.75f, 2.375f, 4.0f };    // ������ ���� y��ġ (�ֺ� ������� �� ��ġ)

    void Update()
    {
        this.delta += Time.deltaTime;

        // 3.5�ʸ��� ��ħ �߻�
        if (this.delta > this.span)
        {
            delta = 0;

            // ������ ������Ʈ 1�� ����
            GameObject createItem = Instantiate(ItemPrefab) as GameObject;
            GameObject.Find("item_create").GetComponent<AudioSource>().Play();  // ������ ���� ȿ����

            float itemPosX = Random.Range(-4, 4)*2; // -8, -6, -4, -2, 0, 2, 4, 6, 8 �� x position ����. (x��ǥ�� stage1�� �����ϹǷ�)
            float itemPosY = itemPos[Random.Range(0, 5)];   // 4.0, 2.375, 0.75, -0.875, -2.5�� y position ����

            createItem.transform.position = new Vector3(itemPosX, itemPosY, 0);   // ������ ��ġ�� ������ ��ġ
            //Debug.Log("������ �߰�!");
        }
    }
}