using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    bool gameHasEnded = false;
    public float restartDelay = 3f;
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            FindObjectOfType<Score>().checkScore();
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            SceneManager.LoadScene("Credits");
        }
        else
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("sceneOne");
        }
    }
}
