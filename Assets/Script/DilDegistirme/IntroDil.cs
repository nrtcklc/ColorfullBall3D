using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroDil : MonoBehaviour
{
    public GameObject ingilizce;
    public GameObject turkce;
    public GameObject rusca;
    public GameObject almanca;
    public GameObject fransýzca;
    public GameObject portekizce;
    public GameObject ispanyolca;
    public GameObject italyanca;
    public GameObject ozbekce;
    public GameObject cince;
    public GameObject dilSecCanvas;

    public void Start()
    {
        if (Application.systemLanguage == SystemLanguage.English)
        {
            dilSecCanvas.SetActive(false);
            ingilizce.SetActive(true);
        }
        else if (Application.systemLanguage == SystemLanguage.Turkish)
        {
            dilSecCanvas.SetActive(false);
            turkce.SetActive(true);

        }
        else if (Application.systemLanguage == SystemLanguage.Russian)
        {
            dilSecCanvas.SetActive(false);
            rusca.SetActive(true);
        }
        else if (Application.systemLanguage == SystemLanguage.German)
        {
            dilSecCanvas.SetActive(false);
            almanca.SetActive(true);
        }
        else if (Application.systemLanguage == SystemLanguage.German)
        {
            dilSecCanvas.SetActive(false);
            almanca.SetActive(true);
        }
        else
        {
            dilSecCanvas.SetActive(true);
        }
    }
    public void Turkce()
    {
        dilSecCanvas.SetActive(false);
        turkce.SetActive(true);
    }

   public void Rusca()
    {
        dilSecCanvas.SetActive(false);
        rusca.SetActive(true);
    }

   public void Ingilizce()
    {
        dilSecCanvas.SetActive(false);
        ingilizce.SetActive(true);
    }
}
