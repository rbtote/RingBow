using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class bunnyWalk : MonoBehaviour {

	NavMeshAgent nav;                   

    private GameObject[] GetCarrots()
    {
        return GameObject.FindGameObjectsWithTag("Carrot");
    }

    private GameObject FindClosestCarrot()
    {
        GameObject[] carrots = GetCarrots();
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject carrot in carrots)
        {
            Vector3 diff = carrot.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = carrot;
                distance = curDistance;
            }
        }
        return closest;
    }

    void Start()
    {
        GameObject carrot = FindClosestCarrot();
        nav = GetComponent<NavMeshAgent>();
        nav.SetDestination(carrot.transform.position);        
    }


    void Update()
    {
        GameObject carrot = FindClosestCarrot();
        Debug.Log("Carrot found"+carrot);
        if (!carrot)
        {
            nav.enabled = false;
        }        
        nav.SetDestination(carrot.transform.position);
    }
}
