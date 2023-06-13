using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoring : MonoBehaviour
{

    TextMeshProUGUI scoreText;
    public static int score;

    private void Start()
    {
        gameObject.GetComponent<Shoot>().enabled = true;
        scoreText = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        scoreText.text = "SCORE " + score.ToString();
    }



}
