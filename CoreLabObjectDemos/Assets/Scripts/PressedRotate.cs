using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressedRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        if(Input.GetKey("up")){
        transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
        }
        
        if(Input.GetKey("down")){
        transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime * -1);
        }
        
    }
}