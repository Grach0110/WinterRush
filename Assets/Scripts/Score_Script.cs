using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score_Script : MonoBehaviour
{
    public Text scoreText;
    /// <summary>
    /// количество очков
    /// </summary>
    public int score = 0;

    private void Start()
    {
        scoreText.GetComponent<Text>();
        scoreText.text = "Счет: " + score.ToString();
    }

    public void NewScore()
    {
        score++;
        scoreText.text = "Счет: " + score.ToString();
    }
}