using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UnityEngine.UI namespace is a part of the Unity game engine
using UnityEngine.SceneManagement; // The "UnityEngine.SceneManagement" namespace provides functionality for managing scenes in Unity.

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    KeyCode PauseKeyCode = KeyCode.P;
    public GameObject pausePanel;

    void Start()
    {
        Time.timeScale = 1f;
    }
    void Update()
    {
        if (Input.GetKeyDown(PauseKeyCode))
        {
            Debug.Log("Pause key pressed. Current time scale: " + Time.timeScale);
            if (Time.timeScale == 0) Resume();

            else Pause();
        }
    }

    void Pause()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
        Debug.Log("Pause Called");

    }

    void Resume()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        Debug.Log("Resume Called");

    }
    public void addScore(int scoreTadd)
    {
        playerScore = playerScore + scoreTadd;
        scoreText.text = playerScore.ToString();
        //scoreText is the variable representing the UI Text component, and .text is accessing the text property of that component.
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        Destroy(pausePanel);

    }
    public void goToMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

}
