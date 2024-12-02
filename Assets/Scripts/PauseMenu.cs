using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject PauseScreen;
    public Text scoreText;

    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void MainMenu()
    {
        ScoreClear();
        Time.timeScale = 1;
    }

    public void Resume()
    {
        Time.timeScale = 1;
    }

    //button functions

    public void ScoreClear()
    {
        scoreText.text = "Score: ";
    }
}
