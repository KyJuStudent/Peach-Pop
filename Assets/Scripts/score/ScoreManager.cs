using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;

    int score = 0;
    int highScore = 0;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text =  "Points: " + score.ToString();
    }

    public void AddPoint(int scoreAdd)
    {
        score += scoreAdd;
        scoreText.text =  "Points: " + score.ToString();
    }

    public void ClearScore()
    {
        scoreText.text = "Points: ";
    }
}
