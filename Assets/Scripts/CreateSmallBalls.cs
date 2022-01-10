using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSmallBalls : MonoBehaviour
{
    public GameObject[] prefabs;

    public float spawnX;
    public float spawnY;
    public float spawnZ;

    public GameObject box;
    // Start is called before the first frame update
    void Start()
    {
        float x = box.transform.position.x;
        float y = box.transform.position.y;
        float z = box.transform.position.z;
        StartCoroutine(CreateBalls(x,y,z));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CreateBalls(float x, float y, float z) {
		while (true) {

            spawnX = (float)(x-0.7);
            spawnY = (float)(y-0.5);
            spawnZ = (float)(z+0.2);
			
		    Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(spawnX, spawnY, spawnZ), Quaternion.identity);
			

			// pause 1-5 seconds until the next coin spawns
			yield return new WaitForSeconds(4);
		}
	}
}
