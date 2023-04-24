using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{

    public int timeToBeVisible = 5;
    public int points;
    public bool isVisible = true;


    public virtual void StartCountingFoodTime() 
    {
        StartCoroutine(FoodCounter(timeToBeVisible));
    }

    private IEnumerator FoodCounter(int timeVisible) 
    {
        if (timeVisible < 0)
        {
            isVisible = false;
            StopCoroutine(FoodCounter(timeToBeVisible));
        }
        while (timeVisible >= 0) 
        {
            yield return new WaitForSeconds(1);
            timeToBeVisible--;
        }
        
    }


}
