using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;
    //public AudioManager audioManager;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            FindObjectOfType<FollowPlayer>().RemoveInvoke("Spawn");
            movement.enabled = false;
            AudioManager.instance.PlayHit();
            //FindObjectOfType<AudioManager>().Play("CubeHit");
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
