using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileManager : MonoBehaviour {

    public float lifeSpan;
    private float timer;
	// Use this for initialization
	void Start () {
        timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(timer);
        if (timer >= lifeSpan)
        {
            Destroy(this.gameObject);
        }
        else
        {
            timer+=Time.deltaTime;
        }
	}
}
