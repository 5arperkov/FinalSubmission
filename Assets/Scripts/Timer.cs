using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // ENCAPSULATION
    public static Timer instance { get; private set; }

    public int startTime = 60;

    public Text displayTimeText;

    public bool gameIsRunning = true;


    void Awake() 
    {
        instance = this;
    }


    public void StartCounting() 
    {
        StartCoroutine(TimeCounter(startTime));
    }

    // ABSTRACTION
    private IEnumerator TimeCounter(int totalTime)
    {
        while (gameIsRunning)
        {
            displayTimeText.text = "Time left : " + totalTime;
            yield return new WaitForSeconds(1.0f);
            totalTime -= 1;
            if (totalTime < 0)
            {
                gameIsRunning = false;
                StopCoroutine(TimeCounter(startTime));
            }
        }

    }
}
