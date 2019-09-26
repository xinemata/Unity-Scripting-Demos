using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTransform : MonoBehaviour
{

    public GameObject ball;
    public float x = 3;
    public float grow = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        ball.transform.localScale = new Vector3(x,x,x);
    }

    // Update is called once per frame
    void Update()
    {

        ball.transform.localScale += new Vector3(grow,grow,grow);

        Debug.Log(ball.transform.localScale.x);
        
    }
}
