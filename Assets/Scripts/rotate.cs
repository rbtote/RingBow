using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    //Rotational Speed
    public float speed = 0f;


    void Update()    {
        //Forward Direction
        if (Input.GetKey("right")){
            transform.Rotate(0, Time.deltaTime * speed, 0, Space.Self);
        }

        //Reverse Direction
        if (Input.GetKey("left")){
            transform.Rotate(0, -Time.deltaTime * speed, 0, Space.Self);
        }
    }
}
