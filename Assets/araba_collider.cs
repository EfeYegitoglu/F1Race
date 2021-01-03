using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class araba_collider : MonoBehaviour
{
    AudioSource ses;

    void Start()
    {
        ses = GetComponent<AudioSource>();
    }



    void ol()
    {
        

        SceneManager.LoadScene("Scenes/Menu");
    }

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "enemy")
        {
            ses.Play();
            
            Invoke("ol",0.4f);
            //SceneManager.LoadScene("Scenes/Menu");
        }

    } 

    /*void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name=="a")
        {
            ses.Play();
            Invoke("ol",0.4f);
        }
    }*/

   


}
