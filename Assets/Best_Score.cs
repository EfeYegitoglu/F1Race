using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Best_Score : MonoBehaviour
{
    public Text puan;
    void Start()
    {
        int enYuksekPuan = PlayerPrefs.GetInt("kayit");
        puan.text = "BEST SCORE:\n" + enYuksekPuan;
    }

    
    void Update()
    {
        
    }
}
