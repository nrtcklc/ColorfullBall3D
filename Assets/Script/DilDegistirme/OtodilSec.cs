using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtodilSec : MonoBehaviour
{
    public DilDegistir dilDegistir;
    void Start()
    {
        if (Application.systemLanguage == SystemLanguage.English)
        {
            dilDegistir.Cevir("en");
        }
        else if (Application.systemLanguage == SystemLanguage.Turkish)
        {
            dilDegistir.Cevir("tr");
        }
        else if (Application.systemLanguage == SystemLanguage.Russian)
        {
            dilDegistir.Cevir("ru");
        }
        else if (Application.systemLanguage == SystemLanguage.German)
        {
            dilDegistir.Cevir("de");
        }
        else if (Application.systemLanguage == SystemLanguage.French)
        {
            dilDegistir.Cevir("fr");
        }
        else if (Application.systemLanguage == SystemLanguage.Portuguese)
        {
            dilDegistir.Cevir("pt");
        }
        else if (Application.systemLanguage == SystemLanguage.Spanish)
        {
            dilDegistir.Cevir("es");
        }
        else if (Application.systemLanguage == SystemLanguage.Italian)
        {
            dilDegistir.Cevir("it");
        }
        else if (Application.systemLanguage == SystemLanguage.Hindi)
        {
            dilDegistir.Cevir("hi");
        }
        else if (Application.systemLanguage == SystemLanguage.Chinese)
        {
            dilDegistir.Cevir("zh");
        }
        else if (Application.systemLanguage == SystemLanguage.Japanese)
        {
            dilDegistir.Cevir("ja");
        }
        else
        {
            dilDegistir.Cevir("en");
        }
    }  
}
