using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carrotSpawn : MonoBehaviour {

    public int carrotNum;
    public int minx, maxx, minz, maxz;
    public GameObject spawn;
    private Vector3 pos = new Vector3();
    private Quaternion rot = new Quaternion();

    // Use this for initialization
    void Start () {
		for(int i=0; i<carrotNum; i++)
        {
            pos = new Vector3(Random.Range(minx, maxx), 0, Random.Range(minz, maxz));
            rot = Quaternion.Euler(-90, 0, 0);
            Instantiate(spawn, pos, rot);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
