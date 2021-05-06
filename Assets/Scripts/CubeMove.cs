using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public float speed;

    public float scope;

    private Vector3 originPos;
    // Start is called before the first frame update
    void Start()
    {
        originPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed*Vector3.up;
        if (transform.position.y>=originPos.y+scope || transform.position.y <=originPos.y-scope)
        {
            speed = -speed;
        }
    }
}
