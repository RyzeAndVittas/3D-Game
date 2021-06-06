using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Transform cam;
    public Vector3 vector;
    
    
    

    // Update is called once per frame
    void Update()
    {
        cam.position = (player.position + vector);
        
    }
}
