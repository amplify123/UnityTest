using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    public float delay = 1.0f;
    float countdown;
    bool hasExploded = false;
    bool canExplode = false;
    public float force = 700f;
    public float BlastRadius = 5f;
    public GameObject explosionEffect;

    void Start()
    {
        countdown = delay;
    }

    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f && !hasExploded && canExplode)
        {

            Explode();
            hasExploded = true;
        }

    }

    void Explode()
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);

        Collider[] colliders = Physics.OverlapSphere(transform.position, BlastRadius);

        foreach (Collider nearbyObjects in colliders)
        {
            Rigidbody rb = nearbyObjects.GetComponent<Rigidbody>();
            if (rb != null)
            {

                rb.AddExplosionForce(force, transform.position, BlastRadius);
            }

        }


        Destroy(gameObject);
    }
}
