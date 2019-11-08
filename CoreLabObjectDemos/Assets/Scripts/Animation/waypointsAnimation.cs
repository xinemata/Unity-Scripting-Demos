using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypointsAnimation : MonoBehaviour
{
    public GameObject[] waypoints; // an array of game objs called waypoints
    int current = 0; // check which waypoint in the array
    float rotSpeed; // rotate the game objs
    public float speed;
    float WPradius = 1; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
        {
            current++;
            
            if (current >= waypoints.Length)
            {
                current = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
    }
}
