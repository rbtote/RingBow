using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

    public float cooldown = 10;
    float timer;
    int times = 0;
    public GameObject projectile;


    // Update is called once per frame
    void Update () {
        timer += Time.deltaTime;
        if (Input.GetKeyDown("space") && timer >= cooldown)
        {
            timer = 0;
            // Instantiate the projectile at the position and rotation of this transform
            GameObject clone;
            clone = Instantiate(projectile, transform.position, transform.rotation);

            // Give the cloned object an initial velocity along the current
            // object's Z axis
            clone.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.forward * 10);
            
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}