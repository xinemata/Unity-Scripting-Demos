using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicAnimationDemo : MonoBehaviour
{

    public Transform turtle;

    public float moveSpeed = 5f;
    public float rotateSpeed = 80f;

    private float y = 1;

    // Start is called before the first frame update
    void Start()
    {

        //transform.position = new Vector3 (0f, 0.5f, 1.5f);
        
    }

    // Update is called once per frame
    void Update()
    {

        if(turtle){

            float dist = Vector3.Distance(turtle.position, transform.position);

            if (dist < 5f){

                transform.rotation = Quaternion.Euler(0f,y,0f);

                if(y > 180){
                    y -= Time.deltaTime * rotateSpeed;
                } else if (y < 0){
                    y += Time.deltaTime * rotateSpeed;
                }
                
                // if (transform.position.x >= turtle.position.x){
                //     transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
                // } else if (transform.position.x < turtle.position.x){
                //     transform.Rotate(Vector3.up * Time.deltaTime * -rotateSpeed);
                // }

            Debug.Log("Too close!");

            } else {

             Debug.Log("Safe distance!");   

            }

        }

        Teleport();
    }

    void Teleport(){
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);

        if (transform.position.z > 7f || transform.position.z < -7f)
        {
            moveSpeed = moveSpeed * -1;
        } 

    }
}
