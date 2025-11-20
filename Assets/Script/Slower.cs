using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slower : MonoBehaviour
{
    public GameObject timeIcon;
    public GameObject timeEffect;
    public GameObject TimeCountDown;
    public GameObject slower;
    public Image coinImage;
    public Text priceCoinText;

    public UIManager uiManager;
    public CameraMove cameraMove;
    public Player player;

    public GameObject shield;

    public void TimeSlowerButton()
    {
        int money = PlayerPrefs.GetInt("moneyy");
        if (money >= 100)
        {
            PlayerPrefs.SetInt("moneyy", money - 100);
            cameraMove.forwardSpeed = 5.0f;
            player.forwardSpeed = 5;
            uiManager.CoinTextUpdate();
            timeEffect.SetActive(true);
            TimeCountDown.SetActive(true);
            Destroy(coinImage);
            Destroy(priceCoinText);
            StartCoroutine("TimeEffcetTime");
            if (money < 200) 
            {
                shield.SetActive(false);
            }
        }
        else
        {
            Debug.Log("There is not enoght coin");
        }
    }
    IEnumerator TimeEffcetTime()
    {
        yield return new WaitForSeconds(5f);
        timeEffect.SetActive(false);
        timeIcon.SetActive(false);
        TimeCountDown.SetActive(false);
        cameraMove.forwardSpeed = 10.0f;
        player.forwardSpeed = 10;
        slower.SetActive(false);
    }
}
