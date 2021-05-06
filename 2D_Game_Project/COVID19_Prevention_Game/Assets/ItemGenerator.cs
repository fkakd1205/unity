using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game1 - Stage1�� ������ Generator
public class ItemGenerator : MonoBehaviour
{
    public GameObject ItemPrefab;
    private float span = 7.0f;  // 7�ʸ��� ������ ����
    private float delta = 0;
    private GameObject createItem;

    void Update()
    {

        this.delta += Time.deltaTime;

        // 3.5�ʸ��� ��ħ �߻�
        if (this.delta > this.span)
        {
            delta = 0;
            // ������ ������Ʈ 1�� ����
            createItem = Instantiate(ItemPrefab) as GameObject;
            GameObject.Find("item_create").GetComponent<AudioSource>().Play();  // ������ ���� ȿ����

            int itemPosX = Random.Range(-4, 5) * 2; // -8, -6, -4, -2, 0, 2, 4, 6, 8 �� x position ����
            int itemPosY = Random.Range(-1, 3) * 2;   // -4, -2, 0, 2, 4 �� y position ����

            createItem.transform.position = new Vector3(itemPosX, itemPosY, 0);   // ������ ��ġ�� ������ ��ġ
            //Debug.Log("������ �߰�!");
        }
    }
}
