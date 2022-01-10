using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
       // Start is called before the first frame update
    public int turn;
    public float positionY;
    float x;
    float z;
    public GameObject floor;
    void Start()
    {
        x = gameObject.transform.position.x;
        z = gameObject.transform.position.z;

        positionY = floor.transform.position.y;
        StartCoroutine(SpikeMove(turn));

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpikeMove(int turn) {
        bool first = true;
		while (true) {
        
            if (turn == 1 & first)
            {
                yield return new WaitForSeconds((float)(Random.Range(20, 40)/10));
            }
            if (gameObject.transform.position.y < positionY - 6)
            {
                gameObject.transform.position = new Vector3(x, (float)(positionY-0.98), z);
                yield return new WaitForSeconds((float)(Random.Range(20, 40)/10));
            }
            else
            {
                gameObject.transform.position = new Vector3(x, positionY-10, z);
                yield return new WaitForSeconds((float)(Random.Range(20, 40)/10));
            }
            
		    
		}
	}
}
