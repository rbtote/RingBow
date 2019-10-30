using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bunnySpawner : MonoBehaviour {

    public int level;
    private int maxBunnies;
    public int minx, maxx, minz, maxz;
    public GameObject spawn;
    float tiempo=0;
    private Vector3 pos = new Vector3();
    private int contador, separacion;

    // Use this for initialization
    void Start () {
        separacion = 3;
        maxBunnies =  level * 5;
        contador = 0;
	}

    // Update is called once per frame
    void Update() {
        tiempo += Time.deltaTime;

        if ((contador < maxBunnies) && (tiempo>separacion))
        { 
            pos = new Vector3(Random.Range(minx, maxx), 0, Random.Range(minz, maxz));
            Instantiate(spawn, pos, transform.rotation);
            contador += 1;          
            tiempo = 0;
        }
    }
}