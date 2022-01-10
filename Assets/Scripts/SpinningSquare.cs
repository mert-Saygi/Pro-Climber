using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningSquare : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed;
    public string direction;

    void Start()
    {
        if (direction == "counter")
        {
            speed = -speed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate (new Vector3 (0, speed, 0) * Time.deltaTime);

    }
}
