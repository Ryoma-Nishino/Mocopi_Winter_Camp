using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testcord : MonoBehaviour
{
    [SerializeField]
    [Tooltip("����������G�t�F�N�g(�p�[�e�B�N��)")]
    public GameObject particleObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var effect = Instantiate(particleObject);
        effect.transform.position = this.transform.position;
        Destroy(effect, 1f);
    }
}
