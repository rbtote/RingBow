using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

    public float cooldown = 10;
    float timer;
    int times = 0;
    public GameObject projectile;
    public int state=0;  // 0 equals normal shot, 1 equals triple shot


    // Update is called once per frame
    void Update () {
        timer += Time.deltaTime;
        if (Input.GetKeyDown("space") && timer >= cooldown)
        {
            timer = 0;
            // Instantiate the projectile at the position and rotation of this transform
            GameObject clone,clone1,clone2,clone3;
            if(state == 0)
            {
                clone = Instantiate(projectile, transform.position, transform.rotation);
                // Give the cloned object an initial velocity along the current
                // object's Z axis
                clone.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.forward * 10);
            }
            else
            {
                clone1 = Instantiate(projectile, transform.position, transform.rotation);
                clone2 = Instantiate(projectile, transform.position, transform.rotation);
                clone3 = Instantiate(projectile, transform.position, transform.rotation);

                // Give the cloned object an initial velocity along the current
                // object's Z axis
                clone1.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.forward * 10);
                clone2.GetComponent<Rigidbody>().velocity = transform.TransformDirection(45,0,0);
                clone3.GetComponent<Rigidbody>().velocity = transform.TransformDirection(-45,0,0);
            }            
            
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}