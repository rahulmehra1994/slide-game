using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;


    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            //audioManager.Play("CubeHit");
            FindObjectOfType<AudioManager>().Play("CubeHit");
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
