using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerMenu_Script : MonoBehaviour
{
    /// <summary>
    /// Снежинки
    /// </summary>
    public GameObject snowflakes;
    /// <summary>
    /// Время до появление снежинки
    /// </summary>
    public float timeRespawnSnowflakes;
    float timer;

    /// <summary>
    /// Текущая сцена
    /// </summary>
    public int currentScene;
    /// <summary>
    /// Панель главного меню
    /// </summary>
    GameObject panelMenuGame;
    /// <summary>
    /// Пауза
    /// </summary>
    bool isPause;

    /// <summary>
    /// Количество очков к концу игры \ text
    /// </summary>
    GameObject scoreGameOverText;

    private void Awake()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
    }

    private void Start()
    {
        isPause = false;

        if (currentScene == 0)
        {
            panelMenuGame = null;
            GetComponent<BG_Script>().SceneMenu();
            gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else
        {
            panelMenuGame = GameObject.FindGameObjectWithTag("panelMenuGame");
            panelMenuGame.SetActive(false);

            GetComponent<BG_Script>().SceneGame();

            GetComponent<Score_Script>().StartScore();

            GetComponent<AddGifts_Script>().Points();
            GetComponent<AddGifts_Script>().AddGift();
            gameObject.transform.localScale = new Vector3(2f, 2f, 1f);
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

            timer -= Time.deltaTime;
            if (timer < 0)
            {
                Instantiate(snowflakes,transform);
                timer = timeRespawnSnowflakes;
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
        scoreGameOverText = GameObject.FindGameObjectWithTag("scoreGameOVerText");
        scoreGameOverText.GetComponent<Text>().text = "Ваш счет: " + gameObject.GetComponent<Score_Script>().score;
    }
}