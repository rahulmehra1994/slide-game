using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


    public Rigidbody rb;
    public float forwardForce;
    public float sidewaysForce;

    public string test = "keyboard";
  
    private void Start()
    {
        test = StaticValue.controlType;
        Debug.Log(test);
        AudioManager.instance.Play("GamePlayMusic");
    }

    //fixedUpdate method is preferrable when we are using unity physics to make every thing smoother

    void Update()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //accelerometer inputs
        if (test == "acceleromter")
        {
            if (Input.acceleration.x < -0.015)
            {
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (Input.acceleration.x > 0.015)
            {
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }


        //keyboard inputs
        if (test == "keyboard")
        {
            if (Input.GetKey("d"))
            {
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (Input.GetKey("a"))
            {
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }



        if (rb.position.y < -2f)
        {
            FindObjectOfType<FollowPlayer>().RemoveInvoke("Spawn");
            FindObjectOfType<GameManager>().EndGame();
        }
      
    }












}
