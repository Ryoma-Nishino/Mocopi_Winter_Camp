using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // OnCollisionEnter�֐�
    private void OnCollisionEnter(Collision collision)
    {
        // �p�[�e�B�N���ƏՓ˂����ꍇ
        
    }
    void OnParticleCollision(GameObject other)
    {
        Destroy(gameObject);
    }
}

