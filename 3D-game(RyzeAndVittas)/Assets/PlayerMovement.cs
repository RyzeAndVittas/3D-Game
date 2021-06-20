using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    //here i take reference from the rigidbody and call it rb
    public Rigidbody rb;
    public Transform player;
    bool corner = false;
    public float cd = 1f;
   
    

    void FixedUpdate()
    {
        if (corner = false && Input.GetKey("d"))
        {
            rb.AddForce(100, 0, 0);
            Debug.Log("d is pressed");
        }
        if (player.position == new Vector3(6, 1, 6))
        {
            corner = true;
        }
    }

 

}