using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    float totalTime = 60f;
    bool isGameActive = true;
    public GameObject HUD;
    public GameObject TargetCanvas;

    // Update is called once per frame
    void Update()
    {
        if (isGameActive)
        {
            totalTime -= Time.deltaTime;

            if (totalTime <= 0)
            {
                GameOver();
            }
        }
    }

    void GameOver()
    {
        isGameActive = false;
        HUD.SetActive(false);
        TargetCanvas.SetActive(false);
    }
}
