using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kayit : MonoBehaviour
{
    public GameObject playerimiz;
    //public GameObject nesneler;

    public int kayit_varmi;

    obje_kayitlari obje_kayitlari;

    private void Awake()
    {
        kayit_varmi = PlayerPrefs.GetInt("kayit_varmi");
        obje_kayitlari=GameObject.Find("obje_kayitlari").GetComponent<obje_kayitlari>();

        if (kayit_varmi == 1)
        {
            obje_kayitlari.Listeler();
            //Yukle();
        }
    }
    public void Kaydet()
    {
        Json_Kayit json_kayit=GetComponent<Json_Kayit>();
        bilgiler bilgiler = new bilgiler();

        PlayerPrefs.SetInt("kayit_varmi", 1); 

        //player

        bilgiler.player_x_posizyonu=playerimiz.transform.position.x;
        bilgiler.player_y_posizyonu=playerimiz.transform.position.y;
        bilgiler.player_z_posizyonu=playerimiz.transform.position.z;

        bilgiler.player_x_rotasyonu = playerimiz.transform.eulerAngles.x;
        bilgiler.player_y_rotasyonu = playerimiz.transform.eulerAngles.y;
        bilgiler.player_z_rotasyonu = playerimiz.transform.eulerAngles.z;

       /*
        //nesneler
        foreach (var item in obje_kayitlari.nesneler)
        {
            _nesneler nesneler=new _nesneler();

            nesneler.x_posizyonu=item.transform.position.x;
            nesneler.y_posizyonu=item.transform.position.y;
            nesneler.z_posizyonu=item.transform.position.z;

            nesneler.x_rotasyonu = item.transform.eulerAngles.x;
            nesneler.y_rotasyonu = item.transform.eulerAngles.y;
            nesneler.z_rotasyonu = item.transform.eulerAngles.z;

            bilgiler.nesneler.Add(nesneler);
        }*/
        json_kayit.Json_Kaydet(bilgiler);
    }
    ////////////////////////////YÜKLE/////////////////

    public bilgiler okunan_bilgi;
    public GameObject canvasRestart;
  
    public void Yukle()
    {
        Json_Kayit json_Kayit=GetComponent<Json_Kayit>();
        okunan_bilgi = json_Kayit.Json_Oku();

        //player
        float player_x_poz = okunan_bilgi.player_x_posizyonu;
        float player_y_poz = okunan_bilgi.player_y_posizyonu;
        float player_z_poz = okunan_bilgi.player_z_posizyonu;

        float player_x_rot = okunan_bilgi.player_x_rotasyonu;
        float player_y_rot = okunan_bilgi.player_y_rotasyonu;
        float player_z_rot = okunan_bilgi.player_z_rotasyonu;

        GameObject playerLoad = Instantiate(playerimiz, new Vector3(player_x_poz, player_y_poz, player_z_poz), Quaternion.Euler(player_x_rot, player_y_rot, player_z_rot));
        canvasRestart.SetActive(false);

        playerimiz.transform.position = new Vector3(player_x_poz, player_y_poz, player_z_poz);
        playerimiz.transform.rotation = Quaternion.Euler(player_x_rot, player_y_rot, player_z_rot);

        /*for (int i = 0; i < okunan_bilgi.nesneler.Count; i++)
        {
            float x_poz = okunan_bilgi.nesneler[i].x_posizyonu;
            float y_poz = okunan_bilgi.nesneler[i].y_posizyonu;
            float z_poz = okunan_bilgi.nesneler[i].z_posizyonu;

            float x_rot = okunan_bilgi.nesneler[i].x_rotasyonu;
            float y_rot = okunan_bilgi.nesneler[i].y_rotasyonu;
            float z_rot = okunan_bilgi.nesneler[i].z_rotasyonu;

            GameObject yeni_nesneler = Instantiate(nesneler, new Vector3(x_poz, y_poz, z_poz), Quaternion.Euler(x_rot, y_rot, z_rot));

            obje_kayitlari.nesneler.Add(yeni_nesneler);
        }*/

    }
}
    
