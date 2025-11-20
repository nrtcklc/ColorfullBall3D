using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelMenager : MonoBehaviour
{
    public GameObject loading0;
    public GameObject loading1;
    public GameObject loading2;
    public GameObject loading3;

    public void Start()
    {
        if (PlayerPrefs.HasKey("LevelIndex") == false)
        {
            PlayerPrefs.SetInt("LevelIndex", 1);
        }
        StartCoroutine("LoadingBar");
        LevelControl();
    }
    public void LevelControl()
    {
        int level = PlayerPrefs.GetInt("LevelIndex");
        SceneManager.LoadSceneAsync(level);
    }
    public IEnumerator LoadingBar()
    {
        while (true) 
        {
            loading0.SetActive(true);
            loading1.SetActive(false);
            loading2.SetActive(false);
            loading3.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            loading0.SetActive(false);
            loading1.SetActive(true);
            loading2.SetActive(false);
            loading3.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            loading0.SetActive(false);
            loading1.SetActive(false);
            loading2.SetActive(true);
            loading3.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            loading0.SetActive(false);
            loading1.SetActive(false);
            loading2.SetActive(false);
            loading3.SetActive(true);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
