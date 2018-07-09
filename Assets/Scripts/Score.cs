using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour {
    public Transform player;
    public Text scoreText;
    public Text highScore;

    private void Start()
    {   //this will first time set the highscore to 0
        PlayerPrefs.GetFloat("HighScore", 0);
    }

    // Update is called once per frame
    void Update () {
        //player.position.z;
        scoreText.text = player.position.z.ToString("0"); 
	}


    public void checkScore()
    {
        if ( player.position.z > PlayerPrefs.GetFloat("HighScore"))
        {
            PlayerPrefs.SetFloat("HighScore", player.position.z);
            highScore.text = "High Score: " + player.position.z.ToString("0");//"0" in the ToString argument is to remove decimal 
        }
        else
        {
            highScore.text = "High Score: " + PlayerPrefs.GetFloat("HighScore").ToString("0");
        }
    }
}
