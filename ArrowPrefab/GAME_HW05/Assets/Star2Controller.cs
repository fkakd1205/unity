using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star2Controller : MonoBehaviour
{
    float pos = -0.05f;

    void Start()
    {
    }

    void Update()
    {
        // Star2�� ��,�Ʒ��� ������ �Ÿ��� �̵�
        if (transform.position.y < -3)
            pos *= -1;
        else if (transform.position.y > 3.5)
            pos *= -1;

        transform.Translate(0, this.pos, 0);
    }
}
