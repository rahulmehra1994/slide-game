using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    void Awake()
    {
        AudioManager.instance.Play("MenuScreenMusic");
        AudioManager.instance.Stop("GamePlayMusic");
        Debug.Log("isMUte " + AudioManager.instance.isMute);
    }


    public void StartGame()//start is already a predefined func in unity
    {
        FindObjectOfType<AudioManager>().Stop("MenuScreenMusic");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
