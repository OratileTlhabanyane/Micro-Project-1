using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NoQuizTimer : MonoBehaviour
{
    private int countDownStart = 30;


    public int choiceSelected;
    public Text countdownText;

    [SerializeField] public ScoreSystem scoreSystem;


    // Start is called before the first frame update
    void Start()
    {
        countdownTimer();

    }

    // Update is called once per frame
    void countdownTimer()
    {
        if (countDownStart > 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStart);
            countdownText.text = "Timer : " + spanTime.Minutes + " : " + spanTime.Seconds;
            countDownStart--;
            Invoke("countdownTimer", 1.0f);

        }
        else
        {
            SceneManager.LoadScene(5);
        }
        /*
            if (countDownStart <= 0)
        {
            if (scoreSystem.p1LIVES > scoreSystem.p2LIVES)
            {
                SceneManager.LoadScene(1); //next player's turn
            }
            else
            if (scoreSystem.p2LIVES > scoreSystem.p1LIVES)
            {
                SceneManager.LoadScene(2); //next player's turn
            }

        } */

    }
}


