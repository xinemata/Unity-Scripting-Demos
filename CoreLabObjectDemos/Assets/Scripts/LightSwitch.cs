using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{

    public Light myLight;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // using get key up / down to keep the light on / off
        if (Input.GetKeyDown ("space")) {
            myLight.enabled = !myLight.enabled;
        }
    }
}


//NOTES
//
//        // "up", "down"
//        
//        if (Input.GetKey ("up")) {
//                myLight.enabled = true;
//            } 
//            
//        if (Input.GetKey ("down")){
//                myLight.enabled = false;
//        }

