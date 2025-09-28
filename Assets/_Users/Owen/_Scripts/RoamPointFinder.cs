using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoamPointFinder : MonoBehaviour
{
    public string _roamTag = "RoamPoint";
    public Transform _nearestSpawner;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        FindNearestSpawner();

        if (_nearestSpawner != null)
        {

        }
    }

    void FindNearestSpawner()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag(_roamTag);

        float minDistanceSqr = float.PositiveInfinity;
        _nearestSpawner = null;

        foreach (GameObject target in targets)
        {
            float distanceSqr = (target.transform.position - transform.position).sqrMagnitude;

            if (distanceSqr > minDistanceSqr)
            {
                minDistanceSqr = distanceSqr;
                _nearestSpawner = target.transform;
            }
        }
    }
}
