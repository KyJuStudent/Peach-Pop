using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreAndRemove : MonoBehaviour
{
    public int score;

    private void OnMouseDown()
    {
        Destroy(gameObject);
        ScoreManager.instance.AddPoint(score);
    }

    public void Update()
    {
        Destroy(gameObject, 9f);
    }
}
