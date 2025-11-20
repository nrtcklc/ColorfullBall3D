using System.Collections;
using System.Collections.Generic;
using UnityEngine;




[System.Serializable]
public class bilgiler
{
    /////////////////////////TEK////////////////////////

    public float player_x_posizyonu;
    public float player_y_posizyonu;
    public float player_z_posizyonu;

    public float player_x_rotasyonu;
    public float player_y_rotasyonu;
    public float player_z_rotasyonu;

    /////////////////////////ÇOKLU////////////////////////
    //public List<_nesneler> nesneler=new List<_nesneler> ();
}
/*
[System.Serializable]
public class _nesneler
{
    public float x_posizyonu;
    public float y_posizyonu;
    public float z_posizyonu;

    public float x_rotasyonu;
    public float y_rotasyonu;
    public float z_rotasyonu;
}*/

////////////////////////////OKUMA-YAZMA///////////////////

public class Json_Kayit : MonoBehaviour
{
  public void Json_Kaydet(bilgiler bilgiler)
    {
        string bilgi_Json = JsonUtility.ToJson(bilgiler);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/Bilgiler.json", bilgi_Json);
    }
    public bilgiler Json_Oku()
    {
        string JsonVeri= System.IO.File.ReadAllText(Application.persistentDataPath + "/Bilgiler.json");
        bilgiler okunan_bilgi = JsonUtility.FromJson<bilgiler>(JsonVeri);  
        return okunan_bilgi;
    }
}

