using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpersOnMonoBehaviour : MonoBehaviour
{
    public void QuitApplication()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_WEBPLAYER
            Application.OpenURL (webplayerQuitURL);
        #else
            Application.Quit();
        #endif
    }
}
