using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player")
        {
            ScoreCounter scoreCounter = GameObject.FindObjectOfType<ScoreCounter>();
            if(scoreCounter != null)
            {
                scoreCounter.IncrementScore();
            }
            Destroy(gameObject);
        }
    }
}//class
