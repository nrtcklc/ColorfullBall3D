using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdMenager : MonoBehaviour
{
    InterstitialAd interstitial;
    
    void Start()
    {
        MobileAds.Initialize(initSatus => { });
    }
   public void OnDestroy()
    {
        if (interstitial != null)
        {
            interstitial.Destroy();
        }
    }
}
