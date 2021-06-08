using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    //here i take reference from the rigidbody and call it rb
    public Rigidbody rb;

    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    float horizontalSpeed = 2.0f;
    float verticalSpeed = 2.0f;

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, 10 * Time.deltaTime);
        }
    }

}

