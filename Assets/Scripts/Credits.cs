using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour {
    private void Awake()
    {
        FindObjectOfType<AudioManager>().Stop("GamePlayMusic");
        FindObjectOfType<AudioManager>().Play("EndScreenMusic");
    }

    public void Quit()
    {
        Application.Quit();  
    }
}
