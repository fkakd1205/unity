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

    // target과 밤송이가 충돌했을 때
    void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true;   // 밤송이가 target에 꽂히도록
        GetComponent<ParticleSystem>().Play();  // particle 발사
    }
}
