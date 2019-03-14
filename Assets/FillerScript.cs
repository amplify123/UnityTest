using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillerScript : MonoBehaviour {

    public Renderer rend;

    public float startingMeter = 0;
    public float currentMeter;
    Collider PlayerCollider;
    public GameObject Player;
    private float FillValue = .05f;

    void Start()
    {

        rend = GetComponent<Renderer>();
        PlayerCollider = Player.GetComponent<Collider>();

    }

    void Update()
    {
        

        currentMeter = startingMeter;
        rend.material.SetFloat("_FillAmount", currentMeter);
        



    }

    void OnCollisionEnter(Collision PlayerCollider)
    {
        Debug.Log("HIt");
        //currentMeter = currentMeter + FillValue;
    }
}
