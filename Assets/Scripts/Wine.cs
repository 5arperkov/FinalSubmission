using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wine : Food
{
    public int totalTime;
    void OnEnable()
    {
        timeToBeVisible = totalTime;
        StartCountingFoodTime();
    }

    void Update()
    {
        if (timeToBeVisible < 0)
        {
            Destroy(this.gameObject);
        }
    }
}
