using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collector : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    void IncreaseScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }
     void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Bomb")
        {
            target.gameObject.SetActive(false);
            IncreaseScore();
        }
    }
    
}
