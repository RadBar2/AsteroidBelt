using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    public TMP_Text timer;

    private float startTime;
    private float elapsedTime;
    
    void Update()
    {
        elapsedTime = Time.time - startTime;
        timer.text = $"{Math.Floor(elapsedTime / 60)}:{Math.Floor(elapsedTime)}:{Math.Floor((elapsedTime - Math.Truncate(elapsedTime))*1000)}";
    }
}

