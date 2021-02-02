using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    void Start()
    {
        StartGame();
    }
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = (max + min) / 2;
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Please think of a random number... but don't tell me!");
        Debug.Log("The highest number is: " + max);
        Debug.Log("The lowest number is: " + min);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max += 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Haha! I guessed the number.");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than: " + guess);
    }
}

