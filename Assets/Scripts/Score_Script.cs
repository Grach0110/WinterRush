using UnityEngine;
using UnityEngine.UI;
public class Score_Script : MonoBehaviour
{
    public GameObject scoreText;
    /// <summary>
    /// количество очков
    /// </summary>
    public int score = 0;

    public void StartScore()
    {
        scoreText = GameObject.FindGameObjectWithTag("ScoreGame");
        scoreText.GetComponent<Text>().text = "Счет: " + score.ToString();
    }

    public void NewScore()
    {
        score++;
        scoreText.GetComponent<Text>().text = "Счет: " + score.ToString();
    }
}