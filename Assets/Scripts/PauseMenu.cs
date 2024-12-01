using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject PauseScreen;
    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void Restart()
    {
        Time.timeScale = 1;
    }

    public void Resume()
    {
        Time.timeScale = 1;
    }
}
