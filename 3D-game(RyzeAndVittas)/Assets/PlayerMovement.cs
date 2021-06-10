using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    //here i take reference from the rigidbody and call it rb
    public Rigidbody rb;
    public Transform player;
    



    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;

    void Update()
    {
        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float translation = Input.GetAxis("Horizontal") * speed;
        float rotation = Input.GetAxis("Vertical") * rotationSpeed;

        // Make it move 10 meters per second instead of 10 meters per frame...
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        // Move translation along the object's z-axis
        transform.Translate(translation, 0, 0);
        transform.Translate(0, 0, rotation);






    }

   
    

}