using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public static Boolean gameOver = false;
    public Text textScore, textGameOver;

    // Start is called before the first frame update
    void Start()
    {
        textGameOver.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = "Score: " + score;

        if (gameOver)
        {
            gameOver = true;
        }

        if (score >= 1)
        {
            gameOver = true;
            textGameOver.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && gameOver)
        {
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
           
        }
    }
}
