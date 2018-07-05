using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    void Awake()
    {
        FindObjectOfType<AudioManager>().Play("MenuScreenMusic");
    }
  

    public void StartGame()//start is already a predefined func in unity
    {
        FindObjectOfType<AudioManager>().Stop("MenuScreenMusic");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
