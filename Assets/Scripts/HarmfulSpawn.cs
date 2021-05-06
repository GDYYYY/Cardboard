using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarmfulSpawn : MonoBehaviour
{
    public GameObject cube;

    public float spawnTime;

    private float countTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countTime += Time.deltaTime;
        if (spawnTime <= countTime)
        {
            createHarmCube();
            countTime = 0;
        }
    }
    public void createHarmCube()
    {
        var rad = Random.Range(0, 6.18f);
        var r = Random.Range(3f, 10f);//5.0f;
        Vector3 pos = new Vector3(
            Mathf.Sin(rad) * r, Random.Range(-0.5f, 0.5f), Mathf.Cos(rad) * r
        );
        GameObject cur= Instantiate(cube, pos, Quaternion.identity);
        cur.transform.SetParent(transform);
    }
}
