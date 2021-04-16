using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject ItemPrefab;
    float span = 7.0f;  // 7�ʸ��� ������ ����
    float delta = 0;

    void Start()
    {
        
    }

    void Update()
    {
        this.delta += Time.deltaTime;

        // 3.5�ʸ��� ��ħ �߻�
        if (this.delta > this.span)
        {
            delta = 0;
            // ������ ������Ʈ 1�� ����
            GameObject createItem = Instantiate(ItemPrefab) as GameObject;

            int itemPosX = Random.Range(-4, 5) * 2; // -8, -6, -4, -2, 0, 2, 4, 6, 8 �� x position ����
            int itemPosY = Random.Range(-1, 3) * 2;   // -4, -2, 0, 2, 4 �� y position ����

            createItem.transform.position = new Vector3(itemPosX, itemPosY, 0);   // ������ ��ġ�� ������ ��ġ
            Debug.Log("������ �߰�!");
        }
    }
}
