using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Olustur : MonoBehaviour
{
    public Transform nesneler_yeri;

    public GameObject nesneler;

    obje_kayitlari obje_kayitlari;

    private void Awake()
    {
        obje_kayitlari=GameObject.Find("obje_kayitlari").GetComponent<obje_kayitlari>();
    }

    public void nesneler_olustur()
    {
        GameObject yeni_nesneler=Instantiate(nesneler, nesneler_yeri.transform.position, nesneler_yeri.transform.rotation);
        obje_kayitlari.nesneler.Add(yeni_nesneler);
    }

    public void cikis()
    {
        //SceneManager.LoadScene("ana menu");
    }
}
