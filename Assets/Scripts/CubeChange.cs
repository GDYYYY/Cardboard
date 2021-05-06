using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeChange : MonoBehaviour
{
    public float minSize;

    public float maxSize;
    public float period;
    private float step;

    private bool beBig;
    // Start is called before the first frame update
    void Start()
    {
        beBig = true;
        step = (maxSize-minSize)/(period*20);
    }

    // Update is called once per frame
    void Update()
    {
        // if (transform.localScale.x >= maxSize) beBig = false;
        // else if (transform.localScale.x <= minSize) beBig = true;
        // if(beBig)
        //     transform.localScale += step*Vector3.one;
        // else transform.localScale -= step*Vector3.one;
        
        transform.localScale += step*Vector3.one;
        if (transform.localScale.x > maxSize||transform.localScale.x < minSize) step=-step;
    }
}
