using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    //here i take reference from the rigidbody and call it rb
    public Rigidbody rb;
    public Transform player;
    public float speed = 1f;


    // Update is called once per frame

    void FixedUpdate()
    {
        if (player.position == new Vector3(-6, 1, 6))
        {
            if (Input.GetKey("d"))
            {
                player.position = new Vector3(6, 1, 6);
            }
        }
        if (player.position == new Vector3(6, 1, 6))
        {
            if (Input.GetKey("s"))
            {
                player.position = new Vector3(6, 1, -8);
            }
        }

        if (player.position == new Vector3(6, 1, -8))
        {
            if (Input.GetKey("a"))
            {
                player.position = new Vector3(-6, 1, -8);
            }
        }
        if (player.position == new Vector3(-6, 1, -8))
        {
            if (Input.GetKey("w"))
            {
                player.position = new Vector3(-6, 1, 6);
            }
        }



        if (player.position == new Vector3(-6, 1, 6))
        {
            if (Input.GetKey("s"))
            {
                player.position = new Vector3(-6, 1, -8);
            }
        }
        if (player.position == new Vector3(-6, 1, -8))

        {
            if (Input.GetKey("d"))
            {
                player.position = new Vector3(6, 1, -8);
            }
        }

        if (player.position == new Vector3(6, 1, -8))
        {
            if (Input.GetKey("w"))
            {
                player.position = new Vector3(6, 1, 6);
            }
        }
        if (player.position == new Vector3(6, 1, 6))
        {
            if (Input.GetKey("a"))
            {
                player.position = new Vector3(-6, 1, 6);
            }
        }
    }
}