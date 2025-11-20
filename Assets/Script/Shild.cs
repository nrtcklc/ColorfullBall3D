using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.UI;

public class Shild : MonoBehaviour
{
    public GameObject shild;
    public GameObject shildIconEffect;
    public GameObject shildEffect;
    public GameObject TimeCountDown;
    public Collider player;
    public AudioSource shildSource;
    public Image coinImage;
    public Text priceCoinText;

    public UIManager uiManager;
    public GameObject slower;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    public void ShildButton()
    {
        int money = PlayerPrefs.GetInt("moneyy");
        if (money >= 200)
        {      
            PlayerPrefs.SetInt("moneyy", money - 200);           
            uiManager.CoinTextUpdate();
            shildEffect.SetActive(true);
            shildIconEffect.SetActive(true);
            TimeCountDown.SetActive(true);
            player.enabled = false;
            Destroy(coinImage);
            Destroy(priceCoinText);     
            StartCoroutine("ShildEffcetTime");
            if (money < 100)
            {
                slower.SetActive(false);
            }
        }
        else
        {
            Debug.Log("There is not enoght coin");
        }
    }
    IEnumerator ShildEffcetTime()
    {   
        yield return new WaitForSeconds(5f);
        player.enabled = true;
        shildEffect.SetActive(false);
        shild.SetActive(false);
    }

}
