using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    //here i take reference from the rigidbody and call it rb
    public Rigidbody rb;
    public Transform player;
    public PlayerMovement movement;

    public float speed = 10.0f;

    // Update is called once per frame

    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            rb.AddForce(speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, speed * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -speed * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "wall")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            movement.enabled = false;
            rb.constraints = RigidbodyConstraints.FreezePosition;
        }

    }
}

