using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Fall : MonoBehaviour
{
    public int fall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < fall) {
            SceneManager.LoadScene("GameOver");
		}
    }
}
