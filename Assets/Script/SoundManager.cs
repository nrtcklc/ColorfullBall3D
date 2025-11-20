using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource backgroundSource;
    public AudioSource buttonSource;
    public AudioSource blowUpSource;
    public AudioSource cashSource;
    public AudioSource completeSource;
    public AudioSource objectHitSource;

    public AudioClip buttonClip;
    public AudioClip blowUpClip;
    public AudioClip cashClip;
    public AudioClip completeClip;
    public AudioClip objectHitClip;

    public GameObject soundOn;
    public GameObject soundOff;




    public void Start()
    {

        if (PlayerPrefs.HasKey("Sound") == false)
        {
            PlayerPrefs.SetInt("Sound", 1);
        }

        if (PlayerPrefs.GetInt("Sound") == 1)
        {
            soundOn.SetActive(true);
            soundOff.SetActive(false);

            /*
            backgroundSource.mute = false;
            buttonSource.mute = false;
            blowUpSource.mute = false;
            cashSource.mute = false;
            completeSource.mute = false;
            objectHitSource.mute = false;*/
            
            AudioListener.volume = 1;
        }
        else if (PlayerPrefs.GetInt("Sound") == 2)
        {
            soundOn.SetActive(false);
            soundOff.SetActive(true);
            /*
            buttonSource.mute = true;
            blowUpSource.mute = true;
            cashSource.mute = true;
            completeSource.mute = true;
            objectHitSource.mute = true;*/
            AudioListener.volume = 0;
        }
    }
    public void SoundOn()
    {
            soundOn.SetActive(false);
            soundOff.SetActive(true);
            /*
            backgroundSource.mute = false;
            buttonSource.mute = false;
            blowUpSource.mute = false;
            cashSource.mute = false;
            completeSource.mute = false;
            objectHitSource.mute = false; */
            AudioListener.volume = 0;
            PlayerPrefs.SetInt("Sound", 2);
    }

    public void SoundOff()
    {
            soundOff.SetActive(false);
            soundOn.SetActive(true);
            /*
            buttonSource.mute = true;
            blowUpSource.mute = true;
            cashSource.mute = true;
            completeSource.mute = true;
            objectHitSource.mute = true;
            */
            AudioListener.volume = 1;
            PlayerPrefs.SetInt("Sound", 1);
    }

    public void ButtonSound()
    {
        buttonSource.PlayOneShot(buttonClip);
    }
    public void BlowupSound()
    {
        blowUpSource.PlayOneShot(blowUpClip,0.3f);
    }
    public void CashSound()
    {
        cashSource.PlayOneShot(cashClip);
    }
    public void CompleteSound()
    {
        completeSource.PlayOneShot(completeClip);
    }
    public void ObjectHitSound()
    {
        objectHitSource.PlayOneShot(objectHitClip);
    }
}
