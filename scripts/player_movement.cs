using UnityEngine;

public class player_movement : MonoBehaviour
{
    //this is a referance to tirgidbody component called "rb"
    public Rigidbody rb ;

    public float forwardForce = 2000F;
    public float sidewaysForce = 50f;
    // Update is called once per frame
    //we are marked this as fixed
    // update because we are messing with physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < - 2f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }

}
