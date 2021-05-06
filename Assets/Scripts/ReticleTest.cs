using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void RandomlyTeleport()
    {
        var rad = Random.Range(0, 6.18f);
        var r = 5.0f;
        gameObject.transform.position = new Vector3(
            Mathf.Sin(rad) * r, Random.Range(-0.5f, 0.5f), Mathf.Cos(rad) * r
        );
    }
}
