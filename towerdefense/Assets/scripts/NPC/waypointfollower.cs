using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class waypointfollower : MonoBehaviour
{
    [SerializeField] private float speed = 1;
    [SerializeField] private int nextWaypointIndex = 0; // Changed the initial value to 0
    [SerializeField] private float reachedWaypointClearance = 0.25f;
    [SerializeField] private path path;
    

    void Start()
    {
        path = FindObjectOfType<path>();
        transform.position = path.waypoints[0].position;
        // speed = 10; // No need to set speed again, as you already set it in the inspector
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, path.waypoints[nextWaypointIndex].position) <= reachedWaypointClearance)
        {
            nextWaypointIndex++;

            if (nextWaypointIndex >= path.waypoints.Length)
            {
                nextWaypointIndex = 0;
            }
        }

        // Changed waypoints[1] to waypoints[nextWaypointIndex]
        transform.position = Vector3.MoveTowards(transform.position, path.waypoints[nextWaypointIndex].position, Time.deltaTime * speed);
    }
}
