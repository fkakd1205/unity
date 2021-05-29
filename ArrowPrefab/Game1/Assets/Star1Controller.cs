using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star1Controller : MonoBehaviour
{
    float rot = 1.0f;

    void Start()
    {
    }

    void Update()
    {
        // Star1은 계속해서 회전
        transform.Rotate(0, 0, this.rot);
    }
}
