using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpSpawn : MonoBehaviour
{
    public int powerUpsNum;
    public int minx, maxx, minz, maxz;
    public GameObject spawn;
    private Vector3 pos = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < powerUpsNum; i++)
        {
            pos = new Vector3(Random.Range(minx, maxx), 0, Random.Range(minz, maxz));
            Instantiate(spawn, pos, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
