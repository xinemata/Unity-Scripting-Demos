// these are libraries that allow you to access pre-defined classes and functions
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coloringCube : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer> ().material.color = Color.red;
            Debug.Log("R is pressed");
            transform.position = transform.position + new Vector3(1,1,1);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}
