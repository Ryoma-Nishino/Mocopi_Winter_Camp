using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testcord : MonoBehaviour
{
    [SerializeField]
    [Tooltip("発生させるエフェクト(パーティクル)")]
    public GameObject particleObject;


    [SerializeField]
    [Tooltip("パーティクルの発生方向")]
    public Vector3 particleDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        particleDirection = Quaternion.Euler(90 * Time.deltaTime, 90 * Time.deltaTime, 0) * particleDirection;

        var effect = Instantiate(particleObject);
        effect.transform.position = this.transform.position;
        //effect.transform.forward = particleDirection;
        effect.transform.rotation *= Quaternion.Euler(90 * Time.deltaTime, 90 * Time.deltaTime, 0);
        Destroy(effect, 1f);
    }
}
