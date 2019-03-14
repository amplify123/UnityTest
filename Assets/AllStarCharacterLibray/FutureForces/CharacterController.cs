using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

	public float speed;
    bool grounded;
    private Rigidbody rb;



void Start()
{
    grounded = true;
    rb = GetComponent<Rigidbody> ();
}

void FixedUpdate()
{
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * speed);

        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * speed);

        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * speed);

        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * speed);

        }

if (rb.velocity.y == .05f) { grounded = true; }
 
        if (Input.GetKeyDown("space") && grounded == true)
        {
            rb.AddForce(0, 1000, 0 * Time.deltaTime);
           
        }
       

}
}