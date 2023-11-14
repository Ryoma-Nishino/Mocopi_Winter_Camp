using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // OnCollisionEnter関数
    private void OnCollisionEnter(Collision collision)
    {
        // パーティクルと衝突した場合
        
    }
    void OnParticleCollision(GameObject other)
    {
        Destroy(gameObject);
    }
}

