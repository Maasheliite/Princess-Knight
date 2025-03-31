using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    public GameObject usualCanvas;

    public MobileCode mobileUI;

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
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

    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        mobileUI.UpdateMobileUI();
        usualCanvas.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        mobileUI.HideUI();
        pauseMenuUI.SetActive(true);
        usualCanvas.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

}
