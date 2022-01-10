using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBalls : MonoBehaviour
{
    public GameObject[] prefabs;
    public GameObject player;
    public bool start;
    private float spawnX;
    // Start is called before the first frame update
    void Start()
    {
        spawnX = (float)21.5;
        StartCoroutine(DropBall());

    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x > spawnX - 0.5 & player.transform.position.x < spawnX + 0.5 & player.transform.position.z > 21 & player.transform.position.z < 22)
        {
            start = true;
        }
        
    }

    IEnumerator DropBall() {
		while (spawnX < 29) {
			
            if (start)
            {
                Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(spawnX, (float)(63.5), (float)(21.5)), Quaternion.identity);

                spawnX += 1;
			    
            }
		    yield return new WaitForSeconds((float)0.2);
		}
	}
}
