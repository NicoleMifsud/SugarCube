using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public float minSpeed;
    public float maxSpeed;
    private float currentSpeed;
    private float x, y, z;

    [SerializeField]
    private float _speed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = Random.Range (minSpeed, maxSpeed);
        x = -4f;
        y = Random.Range (-4.0f, 4.0f);
        z = 0.0f;
        transform.position = new Vector3 (x, y, z);
        
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMove();

        //translate the enemy down
        //it needs to move at a speed of 4m/s
        transform.Translate(Vector3.right * _speed * Time.deltaTime);

        if(transform.position.y < -6f)
        {
            float randomX = Random.Range(-4f,4f);
            transform.position = new Vector3(randomX,7.5f,0);
        }

    }
    void EnemyMove()
    {
        float amountToMove = currentSpeed * Time.deltaTime;
        transform.Translate (Vector3.right  * amountToMove);
        if (transform.position.x >= 4f) 
        {
            currentSpeed = Random.Range (minSpeed, maxSpeed);
            y = Random.Range (-4.0f, 4.0f);
            transform.position = new Vector3 (x, y, z);
        }
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Player")
        {
            Destroy(target.gameObject);
            SoundManager.instance.DeathSound();
            GameManager.instance.RestartGame();
        }
    }
}//class