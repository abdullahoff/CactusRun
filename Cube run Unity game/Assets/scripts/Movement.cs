
using System.Threading;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody rb;
    // Start is called before the first frame update
    public float ForwardForce = 2000f;
    public float sidewaysForce = 500f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Add forward force
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
