using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerMenu_Script : MonoBehaviour
{
    int currentScene;
    GameObject panelMenuGame;
    bool isPause;

    GameObject scoreGameOVerText;

    private void Awake()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        isPause = false;
        if (currentScene > 0)
        {
            panelMenuGame = GameObject.FindGameObjectWithTag("panelMenuGame");
            panelMenuGame.SetActive(false);
        }
        else
        {
            panelMenuGame = null;
        }
        
    }

    private void Update()
    {
        if (currentScene > 0)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (isPause)
                {
                    isPause = false;
                    Pause();
                }
                else
                {
                    isPause = true;
                    Pause();
                }
            }
        }
    }

    public void Pause()
    {
        if (isPause)
        {
            Time.timeScale = 0f;
            panelMenuGame.SetActive(true);
        }
        else
        {
            Time.timeScale = 1f;
            panelMenuGame.SetActive(false);
        }
    }

    public void NewGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        panelMenuGame.SetActive(true);
        scoreGameOVerText = GameObject.FindGameObjectWithTag("scoreGameOVerText");
        scoreGameOVerText.GetComponent<Text>().text = "Ваш счет: " + gameObject.GetComponent<Score_Script>().score;
    }
}