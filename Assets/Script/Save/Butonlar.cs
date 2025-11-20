using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Butonlar : MonoBehaviour
{
    public Button devam_et_btn;

    public int kayit_varmi;

    private void Start()
    {
        kayit_varmi = PlayerPrefs.GetInt("kayit_varmi", 0);

        if (kayit_varmi == 0)
        {
            devam_et_btn.interactable = false;
        }

        else
        {
            devam_et_btn.interactable=true;
        }
    }

    public void yeni_oyun()
    {
        PlayerPrefs.SetInt("kayit_varmi", 0);
        //SceneManager.LoadScene("oyun");      
    }

    public void devam_et()
    {
        //SceneManager.LoadScene("oyun");
    }
}
