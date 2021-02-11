﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounds : MonoBehaviour
{

    public float min_X = - 2.6f, max_X = 2.6f, min_Y = -5.6f;
    
    private bool out_Of_Bounds;

    // Update is called once per frame
    void Update()
    {
        CheckBounds();
    }

    void CheckBounds()
    {
        Vector2 temp = transform.position;

        if(temp.x > max_X)
            temp.x = max_X;

        if(temp.x < min_X)
            temp.x = min_X;

        //reset positions
        transform.position = temp;

        if(temp.y <= min_Y)
        {
            if(!out_Of_Bounds)
            {
                out_Of_Bounds = true;

                SoundManager.instance.DeathSound();
                GameManager.instance.RestartGame();
            }
        }
    }//Check bounds

    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "TopSpike")
        {
            transform.position = new Vector2(1000f, 1000f);
            SoundManager.instance.DeathSound();
            GameManager.instance.RestartGame();
        }
    }
}//Class
