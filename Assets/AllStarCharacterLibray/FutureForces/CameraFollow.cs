using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform player;       
    Vector3 NewPos;
    private Vector3 offset;        
    

    
    void Start () 
    {
        
        offset = transform.position - player.transform.position;
        NewPos = new Vector3(player.position.x, player.position.y, 10);
    }
    
    
    void LateUpdate () 
    {
        
        
        transform.position = NewPos + offset;
    }

}
