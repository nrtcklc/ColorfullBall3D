using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public SoundManager soundManager;

    public UnityEngine.UI.Image whiteEffectImage;
    public UnityEngine.UI.Image fillRateImage;
    private int effectControl = 0;
    private bool radialShine;
    
 

    public Animator layoutAnimator;

    public Text coinText;

    //Buttonlar
    public GameObject settingsOpen;
    public GameObject settingsClose;
    public GameObject soundOn;
    public GameObject soundOff;
    public GameObject vibrationOn;
    public GameObject vibrationOff;
    public GameObject iap;
    public GameObject information;
    public GameObject player;
    public GameObject finishLine;
    public GameObject shieldIcon;
    public GameObject timeIcon;
    public GameObject languageIcon;
    public GameObject languageMenu;
    public GameObject shopMenu;
    public GameObject informationMenu;
    public GameObject pauseIcon;
    public GameObject quitButton;

    public GameObject restartMenu;
    public GameObject pauseMenu;
    public GameObject home;

    public GameObject introHand, touchToMove, noAds, shop, settings, layoutBackground, stage, dashStage;
    public GameObject finishScreen, blackBackround, complete, radialShineImage, coin, rewarded, passAd;

    public GameObject achievementCoin, nextLevel;
    public Text achievementText, coinTextFinished;

    private int currentLevel;

    public void Start()
    {
        /*if (PlayerPrefs.HasKey("Sound") == false)
        {
            PlayerPrefs.SetInt("Sound", 1);
        }*/
        if (PlayerPrefs.HasKey("Vibration") == false)
        {
            PlayerPrefs.SetInt("Vibration", 1);
        }
        if (PlayerPrefs.GetInt("NoAds") == 1)
        {
            NoAdsRemove();
        }
        CoinTextUpdate();
    }
    public void NoAdsRemove() 
    {
        noAds.SetActive(false); 
    }
    public void Update()
    {
        if (radialShine == true)
        {
            radialShineImage.GetComponent<RectTransform>().Rotate(new Vector3(0, 0, -15f * Time.deltaTime));
        }
        fillRateImage.fillAmount = ((player.transform.position.z) / (finishLine.transform.position.z));
    }
    public void FirstTouch()
    {
        introHand.SetActive(false);
        touchToMove.SetActive(false);
        noAds.SetActive(false);
        shop.SetActive(false);
        settingsOpen.SetActive(false);
        settingsClose.SetActive(false);
        layoutBackground.SetActive(false);
        soundOn.SetActive(false);
        soundOff.SetActive(false);
        vibrationOn.SetActive(false);
        vibrationOff.SetActive(false);
        iap.SetActive(false);
        information.SetActive(false);
        languageIcon.SetActive(false);
        languageMenu.SetActive(false);
        shopMenu.SetActive(false);
        informationMenu.SetActive(false);
        quitButton.SetActive(false);
        home.SetActive(false);
        stage.SetActive(false);
        dashStage.SetActive(false);
        pauseIcon.SetActive(true);

        int money = PlayerPrefs.GetInt("moneyy");
        if (money < 100)
        {
            timeIcon.SetActive(false);
            shieldIcon.SetActive(false);
        }
        if (money >= 100 && money < 200)
        {
            timeIcon.SetActive(true);
            shieldIcon.SetActive(false);
        }
        if (money >= 200)
        {
            shieldIcon.SetActive(true);
            timeIcon.SetActive(true);
        }
        else
        {
            Debug.Log("There is not enoght coin");
        }
    }
    public void CoinTextUpdate()
    {
        coinText.text = PlayerPrefs.GetInt("moneyy").ToString();
    }
    public void RestartButton()
    {
        restartMenu.SetActive(true);
        shieldIcon.SetActive(false);
        timeIcon.SetActive(false);
    }
    public void RestartScene()
    {
        Variables.firstTouch = 0;
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void NextScene()
    {
        Variables.firstTouch = 0;
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel >= PlayerPrefs.GetInt("unlockLevels"))
        {
            PlayerPrefs.SetInt("unlockLevels", currentLevel + 1);
        }
    }
    public void ReturnHome()
    {
        Variables.firstTouch = 0;
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
    }

    public void FinishScreen()
    {
        StartCoroutine("FinishLaunch");
    }
    public IEnumerator FinishLaunch()
    {
        Time.timeScale = 0.5f;
        pauseIcon.SetActive(false);
        radialShine = true;
        finishScreen.SetActive(true);
        blackBackround.SetActive(true);
        timeIcon.SetActive(false);
        shieldIcon.SetActive(false);
        yield return new WaitForSeconds(0.25f);
        complete.SetActive(true);
        soundManager.CompleteSound();
        yield return new WaitForSeconds(0.5f);
        radialShineImage.SetActive(true);
        coin.SetActive(true);
        soundManager.CompleteSound();
        yield return new WaitForSeconds(0.5f);
        rewarded.SetActive(true);
        soundManager.CompleteSound();
        yield return new WaitForSeconds(1.0f);
        passAd.SetActive(true);
    }

    public void RewardedButton()
    {
        StartCoroutine("AfterRewardButton");
    }
    public IEnumerator AfterRewardButton()
    {
        passAd.SetActive(false);
        coinTextFinished.gameObject.SetActive(false);
        rewarded.SetActive(false);      
        achievementCoin.SetActive(true);
        achievementText.gameObject.SetActive(true);
        CoinCalculator(100);
        for (int i = 100; i < 201; i+=1)
        {
            achievementText.text = "+" + i.ToString();
            coinText.text = PlayerPrefs.GetInt("moneyy").ToString();
            yield return new WaitForSeconds(0.001f);      
        }    
        yield return new WaitForSeconds(0.1f); 
        nextLevel.SetActive(true);
    }
    public void SettingsOpen()
    {
        settingsOpen.SetActive(false);
        settingsClose.SetActive(true);
        layoutAnimator.SetTrigger("SlideIn");

        /*if (PlayerPrefs.GetInt("Sound") == 1)
        {
            soundOn.SetActive(true);
            soundOff.SetActive(false); 
            //AudioListener.volume = 1;
        }
        else if (PlayerPrefs.GetInt("Sound") == 2)
        {
            soundOn.SetActive(false);
            soundOff.SetActive(true);
            //AudioListener.volume = 0;

        }*/
        if (PlayerPrefs.GetInt("Vibration") == 1)
        {
            vibrationOn.SetActive(true);
            vibrationOff.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Vibration") == 2)
        {
            vibrationOn.SetActive(false);
            vibrationOff.SetActive(true);
        }
    }
    public void SettingsClose()
    {
        layoutAnimator.SetTrigger("SlideOut");
        settingsClose.SetActive(false);
        settingsOpen.SetActive(true);
    }
   /* public void SoundOn()
    {
        soundOn.SetActive(false);
        soundOff.SetActive(true); 
        //AudioListener.volume = 0;
        PlayerPrefs.SetInt("Sound", 2);
    }
    public void SoundOff()
    {
        soundOff.SetActive(false);
        soundOn.SetActive(true);
        hitSound.mute = true;
        //AudioListener.volume = 1;
        PlayerPrefs.SetInt("Sound", 1);
    }*/
    public void VibrationOn()
    {
        vibrationOn.SetActive(false);
        vibrationOff.SetActive(true);
        PlayerPrefs.SetInt("Vibration", 2);
    }
    public void VibrationOff()
    {
        vibrationOff.SetActive(false);
        vibrationOn.SetActive(true);
        PlayerPrefs.SetInt("Vibration", 1);
    }
    public void QuitApplication()
    {
        Application.Quit();
    }

    public void PrivacyPolicy()
    {
        Application.OpenURL("https://docs.google.com/document/d/14cr5XIC-qVY4K5JQFn922fuLfzwxp8Vx/edit?usp=drive_link&ouid=115843884881959542974&rtpof=true&sd=true");
    }
    public void TermOfUse()
    {
        Application.OpenURL("https://docs.google.com/document/d/1nGZ3jWRIr2h97mD9MYoNlT4hDS9xrAbU/edit?usp=drive_link&ouid=115843884881959542974&rtpof=true&sd=true");
    }
    public void Facebook()
    {
        Application.OpenURL("https://www.facebook.com/nrtcklc");
    }
    public void Instagram()
    {
        Application.OpenURL("https://www.instagram.com/nrtcklc/");
    }
    public void Twitter()
    {
        Application.OpenURL("https://twitter.com/nrtcklc");
    }
    public void VKontakte()
    {
        Application.OpenURL("https://vk.com/nrtcklc");
    }
    public void Telegram()
    {
        Application.OpenURL("https://t.me/nrtcklc");
    }
    public void Skype()
    {
        Application.OpenURL("https://join.skype.com/invite/nxQe1Tgz3PFE");
    }
    public IEnumerator WhiteEffect()
    {
        whiteEffectImage.gameObject.SetActive(true);
        while (effectControl == 0)
        {
            yield return new WaitForSeconds(0.1f);
            whiteEffectImage.color += new Color(0, 0, 0, 1f);

            if (whiteEffectImage.color == new Color(whiteEffectImage.color.r, whiteEffectImage.color.g, whiteEffectImage.color.b, 1))
            {
                effectControl = 1;
            }
        }
        while (effectControl == 1)
        {
            yield return new WaitForSeconds(0.1f);
            whiteEffectImage.color -= new Color(0, 0, 0, 1f);

            if (whiteEffectImage.color == new Color(whiteEffectImage.color.r, whiteEffectImage.color.g, whiteEffectImage.color.b, 0))
            {
                effectControl = 2;
            }
        }
        if (effectControl == 2)
        {
            Debug.Log("Effect Bitti.");
        }
    }
    public void CoinCalculator(int money)
    {
        if (PlayerPrefs.HasKey("moneyy"))
        {
            int oldScore = PlayerPrefs.GetInt("moneyy");
            PlayerPrefs.SetInt("moneyy", oldScore + money);
        }
        else
            PlayerPrefs.SetInt("moneyy", 0);
    }


}
