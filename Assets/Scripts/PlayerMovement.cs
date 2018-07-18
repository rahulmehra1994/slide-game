using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


    public Rigidbody rb;
    public float forwardForce;
    public float sidewaysForce;
    private float screenCenterX;
    public string test = "screen";
  
    private void Start()
    {
        test = StaticValue.controlType;
        AudioManager.instance.Play("GamePlayMusic");

        // save the horizontal center of the screen
        screenCenterX = Screen.width * 0.5f;
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
                //left
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (Input.acceleration.x > 0.015)
            {
                //right
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }


        if (test == "screen")
        {
            if (Input.touchCount > 0)
            {
                foreach (Touch touch in Input.touches)
                {
                    if (touch.position.x < screenCenterX)
                    {
                        // move left
                        rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                    }
                    else if (touch.position.x > screenCenterX)
                    {
                        // move right
                        rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                    }
                }
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
