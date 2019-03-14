using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandDrag : MonoBehaviour {

    public Camera camera;
   

    void Start()
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;
            transform.LookAt(hit.transform);
            // Do something with the object that was hit by the raycast.
        }
    }
 }
