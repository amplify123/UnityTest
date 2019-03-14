using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class TextMeshFlat : MonoBehaviour {

    private Camera my_camera;

    void Start()
    {
        my_camera = GameObject.Find("EzCamera").GetComponent<Camera>();
    }

    void Update()
    {

        transform.LookAt(transform.position + my_camera.transform.rotation * Vector3.forward,
        my_camera.transform.rotation * Vector3.up);

    }

}
