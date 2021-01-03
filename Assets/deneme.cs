using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deneme : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "a")
        {
            Destroy(col.gameObject);
        }
    }

    

    
}
