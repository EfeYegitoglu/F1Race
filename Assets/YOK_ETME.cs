using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YOK_ETME : MonoBehaviour
{
    public Text puanText;
    int puan = 0;
    int enYuksekPuan = 0;


    void Start()
    {
        enYuksekPuan = PlayerPrefs.GetInt("kayit");
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        puan += 10;
        puanText.text = "" + puan;
        Destroy(col.gameObject);

        if (puan > enYuksekPuan)
        {
            enYuksekPuan = puan;
            PlayerPrefs.SetInt("kayit", enYuksekPuan);
        }
    }





}
