using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbingWallSteps : MonoBehaviour
{
    // Start is called before the first frame update
    public int turn;
    public float positionX;
    float y;
    float z;
    public GameObject wall;
    void Start()
    {
        y = gameObject.transform.position.y;
        z = gameObject.transform.position.z;

        positionX = wall.transform.position.x;
        StartCoroutine(AlternateSteps(turn));

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator AlternateSteps(int turn) {
        if (turn == 1)
        {
            yield return new WaitForSeconds(1);
        }
        else
        {
            yield return new WaitForSeconds(3);

        }
		while (true) {
            if (gameObject.transform.position.x < positionX-1.5)
            {
                gameObject.transform.position = new Vector3((float)(positionX-0.9), y, z);
                yield return new WaitForSeconds(1);
            }
            else
            {
                gameObject.transform.position = new Vector3(positionX-2, y, z);
                yield return new WaitForSeconds(3);
            }
            
		    
		}
	}
}
