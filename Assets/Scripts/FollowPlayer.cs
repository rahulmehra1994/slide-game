using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    public Transform player;
    public Vector3 offset;

    public int enemiesCount = 2;
    public Vector3 enemyOffset;
    public GameObject enemy;
    public float spawnTime = 1f;// How long between each spawn.
    public float delayTime = 0.5f;// How long between each spawn.



    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        for (var i=0; i < enemiesCount; i++)
        {
            InvokeRepeating("Spawn", delayTime, spawnTime);
        }
       
    }

    void Update () {
        transform.position = player.position + offset;//transform is the transform of the gameObject onwhich this script is sitting on   
	}

    void Spawn()
    {
        int rand = Random.Range(-5, 5);

        enemyOffset = new Vector3(Random.Range(-6, 6), 0, enemyOffset.z);

        Instantiate(enemy, transform.position + enemyOffset, transform.rotation);
    }       

}
