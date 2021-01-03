using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_cars_random : MonoBehaviour
{
    Rigidbody car;
    public GameObject[] cars;
    public Vector3 RandomPos;
    int randomObject;
    public int hiz;


    void Start()
    {
        //car = GetComponent<Rigidbody>();
        //randomObject = Random.Range(0,10);
        StartCoroutine(Olustur());
    }

    IEnumerator Olustur()
    {
        while (true)
        {
            for (int i = 0; i < 15; i++)
            {
                Vector3 vec = new Vector3(Random.Range(-RandomPos.x, RandomPos.x), 0, RandomPos.z);
                
                Instantiate(cars[randomObject], vec, Quaternion.identity);
                randomObject = Random.Range(0, 10);
                yield return new WaitForSeconds(0.5f);
            }
            yield return new WaitForSeconds(1f);
        }
    }


    void Update()
    {
        //car.velocity = transform.forward * -hiz;
    }
}
