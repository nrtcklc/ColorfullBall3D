using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DilDegistir : MonoBehaviour
{
    [HideInInspector] public List<Text> tumTextler;
    public List<cevirici> ceviriler;
    public string cevirilecekDil;

    void Start()
    {
        foreach (Text items in Resources.FindObjectsOfTypeAll(typeof(Text)))
        {
            tumTextler.Add(items);
        }
        cevirilecekDil = PlayerPrefs.GetString("dili");

        if (cevirilecekDil == "en")
        {
            Cevir("en");
        }
        else if (cevirilecekDil == "tr")
        {
            Cevir("tr");
        }
        else if (cevirilecekDil == "ru")
        {
            Cevir("ru");
        }
        else if (cevirilecekDil == "de")
        {
            Cevir("de");
        }
        else if (cevirilecekDil == "fr")
        {
            Cevir("fr");
        }
        else if (cevirilecekDil == "pt")
        {
            Cevir("pt");
        }
        else if (cevirilecekDil == "es")
        {
            Cevir("es");
        }
        else if (cevirilecekDil == "it")
        {
            Cevir("it");
        }
        else if (cevirilecekDil == "hi")
        {
            Cevir("hi");
        }
        else if (cevirilecekDil == "zh")
        {
            Cevir("zh");
        }
        else if (cevirilecekDil == "uz")
        {
            Cevir("uz");
        }
        else if (cevirilecekDil == "ja")
        {
            Cevir("ja");
        }
    }
    public void Cevir(string CevirilecekDil)
    {
        for (int i = 0; i < ceviriler.Count; i++)
        {
            for (int s = 0; s < tumTextler.Count; s++)
            {
                if (CevirilecekDil == "en")
                {
                    if (ceviriler[i].Turkce == tumTextler[s].text || ceviriler[i].Rusca == tumTextler[s].text || ceviriler[i].Almanca == tumTextler[s].text || ceviriler[i].Fransýzca == tumTextler[s].text 
                        || ceviriler[i].Portekizce == tumTextler[s].text || ceviriler[i].Ispanyolca == tumTextler[s].text || ceviriler[i].Italyanca == tumTextler[s].text 
                        || ceviriler[i].Hintce == tumTextler[s].text || ceviriler[i].Cince == tumTextler[s].text || ceviriler[i].Ozbekce == tumTextler[s].text || ceviriler[i].Japonca == tumTextler[s].text)
                    {
                        tumTextler[s].text = ceviriler[i].Ingilizce;
                        PlayerPrefs.SetString("dili", "en");
                    }
                }
                if (CevirilecekDil == "tr")
                {
                    if (ceviriler[i].Ingilizce == tumTextler[s].text || ceviriler[i].Rusca == tumTextler[s].text || ceviriler[i].Almanca == tumTextler[s].text || ceviriler[i].Fransýzca == tumTextler[s].text
                        || ceviriler[i].Portekizce == tumTextler[s].text || ceviriler[i].Ispanyolca == tumTextler[s].text || ceviriler[i].Italyanca == tumTextler[s].text
                        || ceviriler[i].Hintce == tumTextler[s].text || ceviriler[i].Cince == tumTextler[s].text || ceviriler[i].Ozbekce == tumTextler[s].text || ceviriler[i].Japonca == tumTextler[s].text)
                    {
                        tumTextler[s].text = ceviriler[i].Turkce;
                        PlayerPrefs.SetString("dili", "tr");
                    }
                }

                if (CevirilecekDil == "ru")
                {
                    if (ceviriler[i].Ingilizce == tumTextler[s].text || ceviriler[i].Turkce == tumTextler[s].text || ceviriler[i].Almanca == tumTextler[s].text || ceviriler[i].Fransýzca == tumTextler[s].text
                        || ceviriler[i].Portekizce == tumTextler[s].text || ceviriler[i].Ispanyolca == tumTextler[s].text || ceviriler[i].Italyanca == tumTextler[s].text
                        || ceviriler[i].Hintce == tumTextler[s].text || ceviriler[i].Cince == tumTextler[s].text || ceviriler[i].Ozbekce == tumTextler[s].text || ceviriler[i].Japonca == tumTextler[s].text)
                    {
                        tumTextler[s].text = ceviriler[i].Rusca;
                        PlayerPrefs.SetString("dili", "ru");
                    }
                }
                if (CevirilecekDil == "de")
                {
                    if (ceviriler[i].Ingilizce == tumTextler[s].text || ceviriler[i].Turkce == tumTextler[s].text || ceviriler[i].Rusca == tumTextler[s].text || ceviriler[i].Fransýzca == tumTextler[s].text
                        || ceviriler[i].Portekizce == tumTextler[s].text || ceviriler[i].Ispanyolca == tumTextler[s].text || ceviriler[i].Italyanca == tumTextler[s].text
                        || ceviriler[i].Hintce == tumTextler[s].text || ceviriler[i].Cince == tumTextler[s].text || ceviriler[i].Ozbekce == tumTextler[s].text || ceviriler[i].Japonca == tumTextler[s].text)
                    {
                        tumTextler[s].text = ceviriler[i].Almanca;
                        PlayerPrefs.SetString("dili", "de");
                    }
                }
                if (CevirilecekDil == "fr")
                {
                    if (ceviriler[i].Ingilizce == tumTextler[s].text || ceviriler[i].Turkce == tumTextler[s].text || ceviriler[i].Rusca == tumTextler[s].text || ceviriler[i].Almanca == tumTextler[s].text
                        || ceviriler[i].Portekizce == tumTextler[s].text || ceviriler[i].Ispanyolca == tumTextler[s].text || ceviriler[i].Italyanca == tumTextler[s].text
                        || ceviriler[i].Hintce == tumTextler[s].text || ceviriler[i].Cince == tumTextler[s].text || ceviriler[i].Ozbekce == tumTextler[s].text || ceviriler[i].Japonca == tumTextler[s].text)
                    {
                        tumTextler[s].text = ceviriler[i].Fransýzca;
                        PlayerPrefs.SetString("dili", "fr");
                    }
                }
                if (CevirilecekDil == "pt")
                {
                    if (ceviriler[i].Ingilizce == tumTextler[s].text || ceviriler[i].Turkce == tumTextler[s].text || ceviriler[i].Rusca == tumTextler[s].text || ceviriler[i].Almanca == tumTextler[s].text
                        || ceviriler[i].Fransýzca == tumTextler[s].text || ceviriler[i].Ispanyolca == tumTextler[s].text || ceviriler[i].Italyanca == tumTextler[s].text
                        || ceviriler[i].Hintce == tumTextler[s].text || ceviriler[i].Cince == tumTextler[s].text || ceviriler[i].Ozbekce == tumTextler[s].text || ceviriler[i].Japonca == tumTextler[s].text)
                    {
                        tumTextler[s].text = ceviriler[i].Portekizce;
                        PlayerPrefs.SetString("dili", "pt");
                    }
                }
                if (CevirilecekDil == "es")
                {
                    if (ceviriler[i].Ingilizce == tumTextler[s].text || ceviriler[i].Turkce == tumTextler[s].text || ceviriler[i].Rusca == tumTextler[s].text || ceviriler[i].Almanca == tumTextler[s].text
                        || ceviriler[i].Fransýzca == tumTextler[s].text || ceviriler[i].Portekizce == tumTextler[s].text || ceviriler[i].Italyanca == tumTextler[s].text
                        || ceviriler[i].Hintce == tumTextler[s].text || ceviriler[i].Cince == tumTextler[s].text || ceviriler[i].Ozbekce == tumTextler[s].text || ceviriler[i].Japonca == tumTextler[s].text)
                    {
                        tumTextler[s].text = ceviriler[i].Ispanyolca;
                        PlayerPrefs.SetString("dili", "es");
                    }
                }
                if (CevirilecekDil == "it")
                {
                    if (ceviriler[i].Ingilizce == tumTextler[s].text || ceviriler[i].Turkce == tumTextler[s].text || ceviriler[i].Rusca == tumTextler[s].text || ceviriler[i].Almanca == tumTextler[s].text
                        || ceviriler[i].Fransýzca == tumTextler[s].text || ceviriler[i].Portekizce == tumTextler[s].text || ceviriler[i].Ispanyolca == tumTextler[s].text
                        || ceviriler[i].Hintce == tumTextler[s].text || ceviriler[i].Cince == tumTextler[s].text || ceviriler[i].Ozbekce == tumTextler[s].text || ceviriler[i].Japonca == tumTextler[s].text)
                    {
                        tumTextler[s].text = ceviriler[i].Italyanca;
                        PlayerPrefs.SetString("dili", "it");
                    }
                }
                if (CevirilecekDil == "hi")
                {
                    if (ceviriler[i].Ingilizce == tumTextler[s].text || ceviriler[i].Turkce == tumTextler[s].text || ceviriler[i].Rusca == tumTextler[s].text || ceviriler[i].Almanca == tumTextler[s].text
                        || ceviriler[i].Fransýzca == tumTextler[s].text || ceviriler[i].Portekizce == tumTextler[s].text || ceviriler[i].Ispanyolca == tumTextler[s].text
                        || ceviriler[i].Italyanca == tumTextler[s].text || ceviriler[i].Cince == tumTextler[s].text || ceviriler[i].Ozbekce == tumTextler[s].text || ceviriler[i].Japonca == tumTextler[s].text)
                    {
                        tumTextler[s].text = ceviriler[i].Hintce;
                        PlayerPrefs.SetString("dili", "hi");
                    }
                }
                if (CevirilecekDil == "zh")
                {
                    if (ceviriler[i].Ingilizce == tumTextler[s].text || ceviriler[i].Turkce == tumTextler[s].text || ceviriler[i].Rusca == tumTextler[s].text || ceviriler[i].Almanca == tumTextler[s].text
                        || ceviriler[i].Fransýzca == tumTextler[s].text || ceviriler[i].Portekizce == tumTextler[s].text || ceviriler[i].Ispanyolca == tumTextler[s].text
                        || ceviriler[i].Italyanca == tumTextler[s].text || ceviriler[i].Hintce == tumTextler[s].text || ceviriler[i].Ozbekce == tumTextler[s].text || ceviriler[i].Japonca == tumTextler[s].text)
                    {
                        tumTextler[s].text = ceviriler[i].Cince;
                        PlayerPrefs.SetString("dili", "zh");
                    }
                }
                if (CevirilecekDil == "uz")
                {
                    if (ceviriler[i].Ingilizce == tumTextler[s].text || ceviriler[i].Turkce == tumTextler[s].text || ceviriler[i].Rusca == tumTextler[s].text || ceviriler[i].Almanca == tumTextler[s].text
                        || ceviriler[i].Fransýzca == tumTextler[s].text || ceviriler[i].Portekizce == tumTextler[s].text || ceviriler[i].Ispanyolca == tumTextler[s].text
                        || ceviriler[i].Italyanca == tumTextler[s].text || ceviriler[i].Hintce == tumTextler[s].text || ceviriler[i].Cince == tumTextler[s].text || ceviriler[i].Japonca == tumTextler[s].text)
                    {
                        tumTextler[s].text = ceviriler[i].Ozbekce;
                        PlayerPrefs.SetString("dili", "uz");
                    }
                }
                if (CevirilecekDil == "ja")
                {
                    if (ceviriler[i].Ingilizce == tumTextler[s].text || ceviriler[i].Turkce == tumTextler[s].text || ceviriler[i].Rusca == tumTextler[s].text || ceviriler[i].Almanca == tumTextler[s].text
                        || ceviriler[i].Fransýzca == tumTextler[s].text || ceviriler[i].Portekizce == tumTextler[s].text || ceviriler[i].Ispanyolca == tumTextler[s].text
                        || ceviriler[i].Italyanca == tumTextler[s].text || ceviriler[i].Hintce == tumTextler[s].text || ceviriler[i].Cince == tumTextler[s].text|| ceviriler[i].Ozbekce == tumTextler[s].text)
                    {
                        tumTextler[s].text = ceviriler[i].Japonca;
                        PlayerPrefs.SetString("dili", "ja");
                    }
                }
            }
        }
    }
}

[System.Serializable]
public class cevirici
{
    public string Ingilizce, Turkce, Rusca, Almanca, Fransýzca, Portekizce, Ispanyolca, Italyanca, Hintce, Cince, Ozbekce, Japonca;
    public cevirici(string ingilizce, string turkce, string rusca, string almanca, string fransýzca, string portekizce, string ispanyolca, string italyanca,string hintce, string cince, string ozbekce, string japonca)
    {
        Ingilizce = ingilizce;
        Turkce = turkce;
        Rusca = rusca;
        Almanca = almanca;
        Fransýzca = fransýzca;
        Portekizce = portekizce;
        Ispanyolca = ispanyolca;
        Italyanca = italyanca;
        Hintce = hintce;
        Cince = cince;
        Ozbekce = ozbekce;
        Japonca = japonca;
    }
}