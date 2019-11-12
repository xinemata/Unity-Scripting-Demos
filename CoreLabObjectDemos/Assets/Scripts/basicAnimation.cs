using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicAnimation : MonoBehaviour
{
    public Transform turtle;

    float ry = 0f;

    bool rToggle = false;

    public float rotateSpeed = 80f;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3 (0f, 0.6f, 1.9f);
    }

    // Update is called once per frame
    void Update()
    {
        teleport(); 

        if (turtle)
        {
            float dist = Vector3.Distance(turtle.position, transform.position);
            // print("Distance to other: " + dist);

            if (dist < 2f){
                rToggle = true; 
            } else {
                rToggle = false;
            }

            if (rToggle == true){
                transform.rotation = Quaternion.Euler(0f,ry,0f);
                ry += Time.deltaTime * rotateSpeed;
            } else if (rToggle == false){
                ry = 0f; 
            }
        }
    }

    void teleport(){
        transform.Translate(Vector3.forward * Time.deltaTime);
        if (transform.position.z > 7f || transform.position.z < -7f)
        {
            transform.position = new Vector3 (0f, 0.6f, -6f);
            transform.rotation = Quaternion.Euler(0f,0f,0f);
        }
    }
}
