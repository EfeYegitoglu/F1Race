using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class araba_kontrol : MonoBehaviour
{
    Rigidbody car;
    public float minX;
    public float maxX;
    public float KarakterHiz = 10f;
    // Start is called before the first frame update
    void Start()
    {
        car = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float hinput = SimpleInput.GetAxis("Horizontal") * KarakterHiz;
        car.transform.Translate(hinput, 0, 0);
        car.position = new Vector3(Mathf.Clamp(car.position.x, minX, maxX),0f,0f);
    }

    /*void onCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "enemy")
        {
            Destroy(col.gameObject);
        }
    }*/


}
