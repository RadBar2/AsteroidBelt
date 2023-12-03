using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    public GameObject Portal;
    public TMP_Text scoreText;
    public int score = 0;

    void Update()
    {
        scoreText.text = $"Asteroids shot: {score}/10";
        if (score == 10) Portal.SetActive(true);
    }
}
