using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public string player_name;

    private int speed;
    private Rigidbody rb;
    

    // Start is called before the first frame update. It is called only ONCE!
    // Autocompletion
    void Start()
    {
        speed = 10;
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame.
    // That means if your game is run at 30 fps,
    // this Update() will be called 30 times/second
    void Update()
    {
        speed++;
        Debug.Log(player_name + " is moving at " + speed + " m/s");
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(transform.forward, ForceMode.Impulse);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(-transform.forward, ForceMode.Impulse);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(transform.right, ForceMode.Impulse);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-transform.right, ForceMode.Impulse);
        }

        
    }


}
