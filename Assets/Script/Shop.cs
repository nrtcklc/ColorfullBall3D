using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public UIManager uiManager;


    public GameObject particle1;
    public GameObject particle2;
    public GameObject particle3;
    public GameObject particle4;
    public GameObject particle5;
    public GameObject particle6;

    public Sprite yellowImage;
    public Sprite greenImage;

    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;
    public GameObject item5;
    public GameObject item6;

    public GameObject lock1;
    public GameObject lock2;
    public GameObject lock3;
    public GameObject lock4;
    public GameObject lock5;
    public GameObject lock6;

    public GameObject coin1;
    public GameObject price1;
    public GameObject coin2;
    public GameObject price2;
    public GameObject coin3;
    public GameObject price3;
    public GameObject coin4;
    public GameObject price4;
    public GameObject coin5;
    public GameObject price5;
    public GameObject coin6;
    public GameObject price6;

    public GameObject notEnoughtMoney;

    public void Awake()

    {
        if (PlayerPrefs.HasKey("itemSelect") == false)
            PlayerPrefs.SetInt("itemSelect", 0);

        //----------------ITEMSELECT----------------
        if (PlayerPrefs.GetInt("itemSelect") == 1)
            Item1Open();

        else if (PlayerPrefs.GetInt("itemSelect") == 2)
            Item2Open();

        else if (PlayerPrefs.GetInt("itemSelect") == 3)
            Item3Open();

        else if (PlayerPrefs.GetInt("itemSelect") == 4)
            Item4Open();

        else if (PlayerPrefs.GetInt("itemSelect") == 5)
            Item5Open();
        else if (PlayerPrefs.GetInt("itemSelect") == 6)
            Item6Open();

        //----------------LOCK------------
        if (PlayerPrefs.HasKey("lock1Control") == false)
            PlayerPrefs.SetInt("lock1Control", 0);

        if (PlayerPrefs.HasKey("lock2Control") == false)
            PlayerPrefs.SetInt("lock2Control", 0);

        if (PlayerPrefs.HasKey("lock3Control") == false)
            PlayerPrefs.SetInt("lock3Control", 0);

        if (PlayerPrefs.HasKey("lock4Control") == false)
            PlayerPrefs.SetInt("lock4Control", 0);

        if (PlayerPrefs.HasKey("lock5Control") == false)
            PlayerPrefs.SetInt("lock5Control", 0);

        if (PlayerPrefs.HasKey("lock6Control") == false)
            PlayerPrefs.SetInt("lock6Control", 0);

        if (PlayerPrefs.GetInt("lock1Control") == 1)
        {
            lock1.SetActive(false);
            coin1.SetActive(false);
            price1.SetActive(false);
        }
            
        if (PlayerPrefs.GetInt("lock2Control") == 1)
        {
            lock2.SetActive(false);
            coin2.SetActive(false);
            price2.SetActive(false);
        }           

        if (PlayerPrefs.GetInt("lock3Control") == 1)
        {
            lock3.SetActive(false);
            coin3.SetActive(false);
            price3.SetActive(false);
        }           

        if (PlayerPrefs.GetInt("lock4Control") == 1)
        {
            lock4.SetActive(false);
            coin4.SetActive(false);
            price4.SetActive(false);
        }          

        if (PlayerPrefs.GetInt("lock5Control") == 1)
        {
            lock5.SetActive(false);
            coin5.SetActive(false);
            price5.SetActive(false);
        }
            
        if (PlayerPrefs.GetInt("lock6Control") == 1)
        {
            lock6.SetActive(false);
            coin6.SetActive(false);
            price6.SetActive(false);
        }
    }
    public void Item1Open()
    {
        particle1.SetActive(true);
        particle2.SetActive(false);
        particle3.SetActive(false);
        particle4.SetActive(false);
        particle5.SetActive(false);
        particle6.SetActive(false);

        item1.GetComponent<Image>().sprite = greenImage;
        item2.GetComponent<Image>().sprite = yellowImage;
        item3.GetComponent<Image>().sprite = yellowImage;
        item4.GetComponent<Image>().sprite = yellowImage;
        item5.GetComponent<Image>().sprite = yellowImage;
        item6.GetComponent<Image>().sprite = yellowImage;

        PlayerPrefs.SetInt("itemSelect", 1);
    }
    public void Item2Open()
    {
        particle1.SetActive(false);
        particle2.SetActive(true);
        particle3.SetActive(false);
        particle4.SetActive(false);
        particle5.SetActive(false);
        particle6.SetActive(false);

        item1.GetComponent<Image>().sprite = yellowImage;
        item2.GetComponent<Image>().sprite = greenImage;
        item3.GetComponent<Image>().sprite = yellowImage;
        item4.GetComponent<Image>().sprite = yellowImage;
        item5.GetComponent<Image>().sprite = yellowImage;
        item6.GetComponent<Image>().sprite = yellowImage;

        PlayerPrefs.SetInt("itemSelect", 2);
    }
    public void Item3Open()
    {
        particle1.SetActive(false);
        particle2.SetActive(false);
        particle3.SetActive(true);
        particle4.SetActive(false);
        particle5.SetActive(false);
        particle6.SetActive(false);

        item1.GetComponent<Image>().sprite = yellowImage;
        item2.GetComponent<Image>().sprite = yellowImage;
        item3.GetComponent<Image>().sprite = greenImage;
        item4.GetComponent<Image>().sprite = yellowImage;
        item5.GetComponent<Image>().sprite = yellowImage;
        item6.GetComponent<Image>().sprite = yellowImage;

        PlayerPrefs.SetInt("itemSelect", 3);
    }
    public void Item4Open()
    {
        particle1.SetActive(false);
        particle2.SetActive(false);
        particle3.SetActive(false);
        particle4.SetActive(true);
        particle5.SetActive(false);
        particle6.SetActive(false);

        item1.GetComponent<Image>().sprite = yellowImage;
        item2.GetComponent<Image>().sprite = yellowImage;
        item3.GetComponent<Image>().sprite = yellowImage;
        item4.GetComponent<Image>().sprite = greenImage;
        item5.GetComponent<Image>().sprite = yellowImage;
        item6.GetComponent<Image>().sprite = yellowImage;

        PlayerPrefs.SetInt("itemSelect", 4);
    }
    public void Item5Open()
    {
        particle1.SetActive(false);
        particle2.SetActive(false);
        particle3.SetActive(false);
        particle4.SetActive(false);
        particle5.SetActive(true);
        particle6.SetActive(false);

        item1.GetComponent<Image>().sprite = yellowImage;
        item2.GetComponent<Image>().sprite = yellowImage;
        item3.GetComponent<Image>().sprite = yellowImage;
        item4.GetComponent<Image>().sprite = yellowImage;
        item5.GetComponent<Image>().sprite = greenImage;
        item6.GetComponent<Image>().sprite = yellowImage;

        PlayerPrefs.SetInt("itemSelect", 5);
    }
    public void Item6Open()
    {
        particle1.SetActive(false);
        particle2.SetActive(false);
        particle3.SetActive(false);
        particle4.SetActive(false);
        particle5.SetActive(false);
        particle6.SetActive(true);

        item1.GetComponent<Image>().sprite = yellowImage;
        item2.GetComponent<Image>().sprite = yellowImage;
        item3.GetComponent<Image>().sprite = yellowImage;
        item4.GetComponent<Image>().sprite = yellowImage;
        item5.GetComponent<Image>().sprite = yellowImage;
        item6.GetComponent<Image>().sprite = greenImage;

        PlayerPrefs.SetInt("itemSelect", 6);
    }
    //-----------------------------------LOCKS-------------------------------
    public void Lock1Open()
    {
        int money = PlayerPrefs.GetInt("moneyy");
        int lock1Control = PlayerPrefs.GetInt("lock1Control");
        if (money >= 500 && lock1Control == 0)
        {
            lock1.SetActive(false);
            coin1.SetActive(false);
            price1.SetActive(false);
            PlayerPrefs.SetInt("moneyy", money - 500);
            PlayerPrefs.SetInt("lock1Control", 1);
            Item1Open();
            uiManager.CoinTextUpdate();
        }
        else
        {
            notEnoughtMoney.SetActive(true);
            StartCoroutine(NotEnoughtMoney());
        }
    }
    public void Lock2Open()
    {
        int money = PlayerPrefs.GetInt("moneyy");
        int lock2Control = PlayerPrefs.GetInt("lock2Control");
        if (money >= 1000 && lock2Control == 0)
        {
            lock2.SetActive(false);
            coin2.SetActive(false);
            price2.SetActive(false);
            PlayerPrefs.SetInt("moneyy", money - 1000);
            PlayerPrefs.SetInt("lock2Control", 1);
            Item2Open();
            uiManager.CoinTextUpdate();
        }
        else
        {
            notEnoughtMoney.SetActive(true);
            StartCoroutine(NotEnoughtMoney());
        }
    }
    public void Lock3Open()
    {
        int money = PlayerPrefs.GetInt("moneyy");
        int lock3Control = PlayerPrefs.GetInt("lock3Control");
        if (money >= 2000 && lock3Control == 0)
        {
            lock3.SetActive(false);
            coin3.SetActive(false);
            price3.SetActive(false);
            PlayerPrefs.SetInt("moneyy", money - 2000);
            PlayerPrefs.SetInt("lock3Control", 1);
            Item3Open();
            uiManager.CoinTextUpdate();
        }
        else
        {
            notEnoughtMoney.SetActive(true);
            StartCoroutine(NotEnoughtMoney());
        }
    }
    public void Lock4Open()
    {
        int money = PlayerPrefs.GetInt("moneyy");
        int lock4Control = PlayerPrefs.GetInt("lock4Control");
        if (money >= 4000 && lock4Control == 0)
        {
            lock4.SetActive(false);
            coin4.SetActive(false);
            price4.SetActive(false);
            PlayerPrefs.SetInt("moneyy", money - 4000);
            PlayerPrefs.SetInt("lock4Control", 1);
            Item4Open();
            uiManager.CoinTextUpdate();
        }
        else
        {
            notEnoughtMoney.SetActive(true);
            StartCoroutine(NotEnoughtMoney());
        }
    }
    public void Lock5Open()
    {
        int money = PlayerPrefs.GetInt("moneyy");
        int lock5Control = PlayerPrefs.GetInt("lock5Control");
        if (money >= 8000 && lock5Control == 0)
        {
            lock5.SetActive(false);
            coin5.SetActive(false);
            price5.SetActive(false);
            PlayerPrefs.SetInt("moneyy", money - 8000);
            PlayerPrefs.SetInt("lock5Control", 1);
            Item5Open();
            uiManager.CoinTextUpdate();
        }
        else
        {
            notEnoughtMoney.SetActive(true);
            StartCoroutine(NotEnoughtMoney());
        }
    }
    public void Lock6Open()
    {
        int money = PlayerPrefs.GetInt("moneyy");
        int lock6Control = PlayerPrefs.GetInt("lock6Control");
        if (money >= 10000 && lock6Control == 0)
        {
            lock6.SetActive(false);
            coin6.SetActive(false);
            price6.SetActive(false);
            PlayerPrefs.SetInt("moneyy", money - 10000);
            PlayerPrefs.SetInt("lock6Control", 1);
            Item6Open();
            uiManager.CoinTextUpdate();
        }
        else
        {
            notEnoughtMoney.SetActive(true);
            StartCoroutine(NotEnoughtMoney());
        }
    }

    IEnumerator NotEnoughtMoney()
    {
        yield return new WaitForSeconds(2);
        notEnoughtMoney.SetActive(false);
    }
}