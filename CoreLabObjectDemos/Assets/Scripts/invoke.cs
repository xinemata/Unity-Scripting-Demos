using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invoke : MonoBehaviour
{

    public GameObject car;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("MakeCar", 2, 1);
        
    }

    void MakeCar(){

        float x = Random.Range(1,2);
        float z = Random.Range(1,2);

        Instantiate(car, new Vector3(x, 0.5f, z), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
