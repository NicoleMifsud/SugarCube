using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyID;

    private float currentSpeed = 2f;

    private float x, y, z;

    [SerializeField]
    private float _speed = 4f;

    void Update()
    {
        if(enemyID == 1)
        {
            EnemyMove();
        }
        else if(enemyID == 2)
        {
            EnemyFlip();
        }        
    }

    void EnemyMove()
    {
        float amountToMove = currentSpeed * Time.deltaTime;
        transform.Translate (Vector3.right  * amountToMove);
        if (transform.position.x >= 4f) 
        {
            y = Random.Range (-4.0f, 4.0f);
            transform.position = new Vector3 (-4, y, z);
        }
    }

    void EnemyFlip()
    {
        float amountToMove = currentSpeed * Time.deltaTime;
        transform.Translate (Vector3.left  * amountToMove);
        if (transform.position.x <= -4f) 
        {
            y = Random.Range (-4.0f, 4.0f);
            transform.position = new Vector3 (4, y, z);
        }
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Player")
        {
            Destroy(target.gameObject);
            Destroy(this.gameObject);
            SoundManager.instance.DeathSound();
            GameManager.instance.RestartGame();
        }
    }
}//class