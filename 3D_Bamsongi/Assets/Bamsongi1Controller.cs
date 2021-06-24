using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bamsongi1Controller : MonoBehaviour
{
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    void Start()
    {
    }

    void Update()
    {
        
    }

    // target�� ����̰� �浹���� ��
    void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true;   // ����̰� target�� ��������
        GetComponent<ParticleSystem>().Play();  // particle �߻�
    }
}
