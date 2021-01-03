using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ENEMY_HARAKET : MonoBehaviour
{
    Rigidbody fizik;
    public int hiz;
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        fizik.velocity = transform.forward * -hiz;
    }

    



}
