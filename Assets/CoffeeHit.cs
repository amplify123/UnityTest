using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeHit : MonoBehaviour
{

    public float enemyDamage = .05f;

    void Start()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cabinet")
        {
            gameObject.GetComponent<Wobble>().TakeDamage(enemyDamage);
        }


    }


  
}
 

