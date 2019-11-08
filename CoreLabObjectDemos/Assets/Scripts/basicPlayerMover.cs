using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicPlayerMover : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 80f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       if (Input.GetKey(KeyCode.UpArrow))
       { 
           Forward();
       } else if (Input.GetKey(KeyCode.DownArrow))
       {
           Backward();
       } else if (Input.GetKey(KeyCode.LeftArrow))
       {
           RotateLeft();
       }

    }

    void Forward(){
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }

    void Backward(){
       transform.Translate(Vector3.forward * Time.deltaTime * -moveSpeed);
    }

    void RotateLeft(){

        transform.Rotate(Vector3.up * Time.deltaTime * -rotateSpeed);

    }

}
