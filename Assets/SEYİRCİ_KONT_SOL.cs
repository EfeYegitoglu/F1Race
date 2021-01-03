using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEYİRCİ_KONT_SOL : MonoBehaviour
{
    public float SEYİRCİ1hiz = -500f;           //YOLLARIN HIZI EKRANA AÇIK YAPILDI
    public float SEYİRCİ2hiz = -500f;
    public GameObject seyirci1;
    public GameObject seyirci2;           //YOL OBJELERİ TANIMLANDI

    Rigidbody fizik1;
    Rigidbody fizik2;               //FİZİKLER TANIMLANDI
    //float uzunluk = 0;

    // Start is called before the first frame update
    void Start() //BAŞLANGIÇTA
    {
        fizik1 = seyirci1.GetComponent<Rigidbody>();           //TANIMLANAN FİZİKLER RİGİDBODY İÇİNE ALINDI İŞLEME AÇILDI
        fizik2 = seyirci2.GetComponent<Rigidbody>();

        fizik1.velocity = new Vector3(0, 0, SEYİRCİ1hiz);          //FİZİKLERİN KONUMUNU X EKSENİNDE DEĞİŞTİREREK HARAKET GÖRÜNÜMÜ SAĞLANDI
        fizik2.velocity = new Vector3(0, 0, SEYİRCİ2hiz);
        //uzunluk = seyirci1.GetComponent<BoxCollider>().size.x;     ////COLLİDERIN X EKSENİNDEKİ YÖNÜNE BAKIYOR VE UZUNLUĞA ATIYOR

    }

    // Update is called once per frame
    void Update()
    {
        if (seyirci1.transform.position.z <= -30f)                           //HARAKETLİ YOL GÖRÜNÜMÜ KAZANDIRILDI. BELLEKTEN TASARRUF EDİLDİ
        {
            seyirci1.transform.position += new Vector3(0, 0, 1030);
        }
        if (seyirci2.transform.position.z <= -20f)
        {
            seyirci2.transform.position += new Vector3(0, 0, 1030);      //YOL 1 VE YOL 2 -X YÖNÜNDE 174 E GELİNCE UZUNLUĞUN 58 KATI KADAR İLERİ IŞINLANSIN 
        }


    }

}
