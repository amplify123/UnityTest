using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointAttach : MonoBehaviour
{
    public GameObject item;
    private GameObject tempParent;
    private Transform guide;
    bool hasPlayer = false;

    Animator Anim;

    void Start()
    {
        guide = GameObject.Find("Guide").transform;
        tempParent = GameObject.Find("Guide");
        Anim = gameObject.GetComponent<Animator>();
        item.GetComponent<Rigidbody>().useGravity = true;
    }

   

    void Update()
    {

        float dist = Vector3.Distance(guide.position,transform.position);

        if (dist < 2.5)
        {

            if (Input.GetMouseButtonDown(0))
            {

                gameObject.GetComponent<AudioSource>().Play();
                item.GetComponent<Rigidbody>().useGravity = false;
                item.GetComponent<Rigidbody>().isKinematic = true;
                item.transform.position = guide.transform.position;
                item.transform.rotation = guide.transform.rotation;
                item.transform.parent = tempParent.transform;
                Anim.SetBool("Open", true);
                Anim.SetBool("Close", false);
            }
        
        }

        if (dist < 2.5f)
        {

            if (Input.GetMouseButtonUp(0))
            {

                item.GetComponent<Rigidbody>().useGravity = true;
                item.GetComponent<Rigidbody>().isKinematic = false;
                item.transform.parent = null;
                item.transform.position = guide.transform.position;
                Anim.SetBool("Open", false);
                Anim.SetBool("Close", true);
            }

        }
    }





}