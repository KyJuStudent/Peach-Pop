using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    float totalTime = 60f; //round time
    bool isGameActive = true; //game active state
    public GameObject HUD; //set HUD for deactivation
    public GameObject TargetCanvas; //canvas to turn off

    public Text scoreText; //connects to HUD score
    public Text finalScore; //Connects to final score object

    public GameObject CongratulationsScreen;    //connects to end game screen


    // Update is called once per frame
    void Update()
    {
        if (isGameActive)               //counts timer down
        {
            totalTime -= Time.deltaTime;

            if (totalTime <= 0)     //activates game over method when timer hits zero
            {
                GameOver();
            }
        }
    }

    void GameOver()
    {               //sets active status to false, turns off HUD and Target canvas, sets a final score to be displayed, and displays final screen
        isGameActive = false;
        HUD.SetActive(false);
        TargetCanvas.SetActive(false);
        CongratulationsScreen.SetActive(true);
        FinalScore();
    }

    public void FinalScore()
    {
        finalScore.text = scoreText.text;
    }
}
