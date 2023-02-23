using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public bool rightMovement = false;
    public bool leftMovement = false;


    // Update is called once per frame
    // Anything related to physics, use it in FixedUpdate

    void Update () {
        if (Input.GetKey("d")) {
            rightMovement = true;
        }
        else{
            rightMovement = false;
        }
        if (Input.GetKey("a")) {
            leftMovement = true;
        }
        else{
            leftMovement = false;
        }
    }
    void FixedUpdate() {
        
        //deltaTime allows the frame rate to be similar on different devices
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (rightMovement == true) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (leftMovement == true ) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f){
            FindObjectOfType<GameManagement>().EndGame();

        }
    }
}
