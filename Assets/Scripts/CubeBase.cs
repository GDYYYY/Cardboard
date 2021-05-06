using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBase : MonoBehaviour
{
    public int value;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void beClicked()
    {
        GameManager.addScore(value);
        GameManager.createCube();
        Destroy(gameObject);
    }
}
