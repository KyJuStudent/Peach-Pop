using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreAndRemove : MonoBehaviour
{
    public int score;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        AudioSource audioSource = GetComponent<AudioSource>();

        audioSource.Play();
        spriteRenderer.enabled = false;
        ScoreManager.instance.AddPoint(score);
    }

    public void Update()
    {
        Destroy(gameObject, 9f);
    }
}
