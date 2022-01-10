using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TitleScreenChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("return")) {
			SceneManager.LoadScene("Level1");
		}
		else if (Input.GetKey("space")) {
			
			SceneManager.LoadScene("Instructions");
		}

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
