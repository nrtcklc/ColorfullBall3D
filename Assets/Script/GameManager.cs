using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public UIManager uiManager;
    public RewaredAds rewaredAds;
    public InterstitialAds interstitialAds;
    public AudioSource BackgroundSource;

    public AudioSource finishedSound;
    public AudioClip finishedClicp;

    public void Start()
    {
        CoinCalculater(0);
        Debug.Log(PlayerPrefs.GetInt("moneyy"));
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("FinishLine"))
        {
            Debug.Log("Game Over");
            if (PlayerPrefs.GetInt("NoAds") == 0)
            {
             interstitialAds.LoadInterstitialAd();
            }
            
            finishedSound.PlayOneShot(finishedClicp);
            BackgroundSource.mute = true;
            rewaredAds.LoadRewardedAd(); 
            CoinCalculater(100);
            uiManager.CoinTextUpdate();
            uiManager.FinishScreen();
            PlayerPrefs.SetInt("LevelIndex", PlayerPrefs.GetInt("LevelIndex") + 1);
        }
    }
    public void CoinCalculater(int money)
    {
        if (PlayerPrefs.HasKey("moneyy"))
        {
            int oldScore = PlayerPrefs.GetInt("moneyy");
            PlayerPrefs.SetInt("moneyy", oldScore + money);
        }
        else
        {
            PlayerPrefs.SetInt("moneyy", 0);
        }
    }
}
