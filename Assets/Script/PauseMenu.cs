using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseIcon;
    public GameObject pauseMenu;
    public SoundManager soundManager;
    public UIManager uiManager;

    public void Pause()
    {
        Time.timeScale = 0.0f;
        AudioListener.volume = 0;
        pauseMenu.SetActive(true);
        pauseIcon.SetActive(false);
        uiManager.home.SetActive(true);
        uiManager.quitButton.SetActive(true);
    }
    public void Continue()
    {
        Time.timeScale = 1.0f;
        pauseMenu.SetActive(false);
        pauseIcon.SetActive(true);
        uiManager.home.SetActive(false);
        uiManager.quitButton.SetActive(false);

        if (PlayerPrefs.HasKey("Sound") == false)
        {
            PlayerPrefs.SetInt("Sound", 1);
        }

        if (PlayerPrefs.GetInt("Sound") == 1)
        {
            AudioListener.volume = 1;
        }
        else if (PlayerPrefs.GetInt("Sound") == 2)
        {      
            AudioListener.volume = 0;
        }
    }
}
