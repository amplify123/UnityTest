using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OnAwake : MonoBehaviour {

    string currentScene;

    Rigidbody[] rb;

    void Update()
    {
        currentScene = SceneManager.GetActiveScene().name;

        if (currentScene == "SampleScene")
        {
            GetComponent<Animator>().enabled = false;
            rb = GetComponentsInChildren<Rigidbody>();
            foreach (Rigidbody body in rb)
            {
               
                body.isKinematic = false;
            }
        }
    }
}

    



