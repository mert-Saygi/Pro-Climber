using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed;
    public int leftEdge;
    public int rightEdge;
    
    void Start()
    {
        if (transform.position.x < leftEdge)
        {
            speed = 1;
        }
        else
        {
            speed = -1;
        }


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate (speed* Time.deltaTime, 0, 0, Space.World);
        transform.Rotate (new Vector3 (0, -60*speed, 0) * Time.deltaTime);


        if (transform.position.x < leftEdge)
        {
            speed = 1;
        }

        if (transform.position.x > rightEdge)
        {
            speed = -1;
        }    
    }
}
