using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coloringCube1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;

            Debug.Log("R is down");

        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.white;

            Debug.Log("R is up");

        }
        
    }
}
