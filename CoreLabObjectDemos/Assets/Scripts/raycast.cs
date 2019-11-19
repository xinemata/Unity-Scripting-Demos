using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit bump;

        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 15f, Color.red);

        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out bump, Mathf.Infinity) && Input.GetKey("down")){

            Debug.Log("bump!");

            Destroy(bump.collider.gameObject);

            // transitions the bumped game obj to a new position
            //bump.collider.gameObject.transform.position = new Vector3(0f, 0f ,0f);

        }
        
    }
}
