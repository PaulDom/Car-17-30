using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stopwatch : MonoBehaviour
{
    public float seconds;
    public float minutes;
    public TextMeshProUGUI stopwatch;

    public bool hasFinished;

    void Update()
    {
        if (!hasFinished)
        {
            seconds += Time.deltaTime;
            if (seconds >= 60)
            {
                minutes += 1;
                seconds -= 60;
            }
            int m = Mathf.RoundToInt(minutes);
            int s = Mathf.RoundToInt(seconds);
            stopwatch.text = m + ":" + s;
        }
    }
}
