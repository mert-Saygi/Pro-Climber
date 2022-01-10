using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    public GameObject character;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        
        if (GameIsPaused)
        {
            if (Input.GetKey("escape"))
            {
                Application.Quit();
            }

            if (Input.GetKey("m"))
            {
                Resume();
                SceneManager.LoadScene("TitleScene");
            }
        }
            
        
    }

    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        character.GetComponent<StarterAssetsInputs>().cursorInputForLook = true;


    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
       character.GetComponent<StarterAssetsInputs>().cursorInputForLook = false;

    }
}
