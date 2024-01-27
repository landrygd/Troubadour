using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class scoreManager : MonoBehaviour
{
    public static scoreManager instance;

    public Text scoreText;
    public Text highscoreText;

    float score = 100;
    int highscore = 0;

    private void Awake()
    {
        instance = this;
    }
void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = score.ToString() + " POINTS";
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }

public void AddPoint(float scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = score.ToString() + " POINTS";
        if (highscore < score)
            PlayerPrefs.SetFloat("highscore", score);
    }

    private void Update()
    {
        if(score > 0)
        {
            score = score - (1f * Time.deltaTime * 10) ;
        }
        else
        {
            score = 0;
            Debug.Log("Tu a perdu...");
        }
        scoreText.text = score.ToString() + " POINTS";
    }
}
