using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    //public bool EnemyMove, EnemyFlip;

    public int enemyID;
    private float currentSpeed = 2f;
    private float x, y, z;

    [SerializeField]
    private float _speed = 4f;

    // Start is called before the first frame update
    void Start()
    {


        //currentSpeed = Random.Range (minSpeed, maxSpeed);
        //x = -4f;
        //y = Random.Range (-4.0f, 4.0f);
        //z = 0.0f;
        //transform.position = new Vector3 (x, y, z);
        
    }

    // Update is called once per frame
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

        //EnemyFlip();

        //translate the enemy down
        //it needs to move at a speed of 4m/s

        

        
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