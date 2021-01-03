using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PAUSE_PLAY : MonoBehaviour
{
    AudioSource ses;
    void Start()
    {
        ses = GetComponent < AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pause()
    {
        ses.Stop();
        Time.timeScale = 0.0f;
    }

    public void resume()
    {
        ses.Play();
        Time.timeScale = 1f;
    }


}
