﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{

    AudioSource honk;

    // Start is called before the first frame update
    void Start()
    {

        honk = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){

        if(other.gameObject.tag == "PickUp"){

            Debug.Log("Collided into other");

            Destroy(other.gameObject);
            honk.Play(); // 

        }

    }

}
