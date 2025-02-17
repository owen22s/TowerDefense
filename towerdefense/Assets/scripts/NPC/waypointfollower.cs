using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Events;

public class waypointfollower : MonoBehaviour
{
    [SerializeField] public float speed = 1;
    [SerializeField] private int nextWaypointIndex = 0;
    [SerializeField] private float reachedWaypointClearance = 0.25f;
    [SerializeField] private path path;

    public UnityEvent OnReachedEnd;

    void Start()
    {
        path = FindObjectOfType<path>();
        

        transform.position = path.waypoints[0].position;
       
    }
    void endline()
    {
        Playerstats.lives--;
        OnReachedEnd.Invoke();
        Destroy(gameObject);
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, path.waypoints[nextWaypointIndex].position, Time.deltaTime * speed);

        if (Vector3.Distance(transform.position, path.waypoints[nextWaypointIndex].position) <= reachedWaypointClearance)
        {
            nextWaypointIndex++;

            
        }
        if (nextWaypointIndex >= path.waypoints.Length)
        { 
            endline();
        }
        
    }

}
