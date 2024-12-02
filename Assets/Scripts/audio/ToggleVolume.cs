using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleVolume : MonoBehaviour
{
    public GameObject toggleObject;
    public bool isAudioEnabled = true;

    void Update()
    {
        if (toggleObject.GetComponent<Toggle>().isOn != isAudioEnabled)
        {
            isAudioEnabled = !isAudioEnabled;

            if(isAudioEnabled)
            {
                AudioListener.volume = 1f;
            }
            else
            {
                AudioListener.volume = 0f;
            }
        }
    }
}
