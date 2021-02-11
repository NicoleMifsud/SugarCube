using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public int Score = 0;

    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        scoreText.text = "Score: " + Score.ToString();
    }

    void Update()
    {

    }

    public void IncrementScore()
    {
        Score++;
        scoreText.text = "Score: " + Score.ToString();
    }
}//class
