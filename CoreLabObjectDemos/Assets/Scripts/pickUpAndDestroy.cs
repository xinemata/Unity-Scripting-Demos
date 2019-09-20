using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpAndDestroy : MonoBehaviour
{
    private int score = 0;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PickUp")
        {
            score = score + 1;
            print("you have collected " + score + " points");
            Destroy(other.gameObject);
        }
    }
}
