using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private Button[] buttons;
    private int unlockLevels;

    private void Start()
    {
        unlockLevels = PlayerPrefs.GetInt("unlockLevels", 1);
        
        for (int i = 0; i < buttons.Length; i++) 
        {
            buttons[i].interactable = false; 
        }

        for (int i = 0; i < unlockLevels; i++)
        {
            buttons[i].interactable = true;
        }
    }
    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
}
