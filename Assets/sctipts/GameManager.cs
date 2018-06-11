using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instanse { set; get; }
    private PlayerMotor motor;
    private float score;
    public Text scoreText;
    public Text scoreText1;

    private void Awake()
    {
        Instanse = this;
        motor = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMotor>();
    }

    private void Update()
    {
        if (motor.IsStarted() && !motor.IsGameOver())
        {
            UpdateScore();
        }
        if (motor.IsGameOver())
        {
            scoreText.enabled = false;
            GameOverScore();
        }
    }

    public void UpdateScore()
    {
        score += Time.deltaTime;
        scoreText.text = ((int)score).ToString();
    }

    public void GameOverScore()
    {
        scoreText1.enabled = true;
        scoreText1.text = "Your Score: " + ((int)score).ToString();
    }
}
