
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb; // reference to the Rigidody componenet called "rb"

    public float jumpForce = 5000f;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float canJump = 0f;


    // Marked as fixedupdate as we are using it to mess with physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // add a forward force

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space) && Time.time > canJump)
        {
            rb.AddForce(new Vector3(0, 7, 0), ForceMode.Impulse);
            canJump = Time.time + 1.5f;
        }
    }
}