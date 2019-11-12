using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicPlayerController : MonoBehaviour
{
    int sequence = 1;
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
            moveForward();
        } else if (Input.GetKey(KeyCode.DownArrow))
        {
            moveBackward();
        } else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotateLeft();
        } else if (Input.GetKey(KeyCode.RightArrow))
        {
            rotateRight();
        }

    }

    void moveForward(){
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }
    void moveBackward(){
        transform.Translate(Vector3.forward * Time.deltaTime * -moveSpeed);
    }
    void rotateLeft(){
        transform.Rotate(Vector3.up * Time.deltaTime * -rotateSpeed);
    }
    void rotateRight(){
        transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
    }

}
