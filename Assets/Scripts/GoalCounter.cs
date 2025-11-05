using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalCounter : MonoBehaviour
{
    public int goalCount = 0;
    public int winGoalCount = 5;
    public Text goalText;
    public GameObject youWinScreen;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Goal"))
        {
            goalCount++;
        }

        if (goalCount >= winGoalCount)
        {
            ShowWinScreen();
        }
    }

    private void Update()
    {
        goalText.text = goalCount.ToString();
    }

    void ShowWinScreen()
    {
        if (youWinScreen != null)
        {
            youWinScreen.SetActive(true);
            Time.timeScale = 0f;
            Debug.Log("Player reached all the goals");
        }
    }
}
