﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3f;

    [SerializeField]
    private int _powerupID;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * _speed);
        //if the powerup position on the y axis is smaller than -6f the power up gets destroyed 
        if(transform.position.y < -6f)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            //if player collides with powerup prefab powerup gets activated and pick up sound will play.
            SugarCube player = other.GetComponent<SugarCube>();
            if(player != null)
            {
                switch(_powerupID)
                {
                    case 0:
                        player.SpeedBoostActive();
                        SoundManager.instance.PickUpSound();
                        Debug.Log("_speed Boost Activated");
                        Destroy(this.gameObject);
                        break;

                    default:
                        Debug.Log("Default Value");
                        break;
                }
            }
        }
    }
}
