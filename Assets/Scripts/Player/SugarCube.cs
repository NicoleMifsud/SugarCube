using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SugarCube : MonoBehaviour
{
    private Rigidbody2D myBody;

    public float moveSpeed = 2f;
    
    private PUSpawner _spawnManager;
    
    [SerializeField]
    private float speedMultiplier = 2f;

    [SerializeField]
    private bool _isSpeedBoostActive = false;
    
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();

        transform.position = new Vector3(0,0,0);
        
        _spawnManager = GameObject.Find("PowerUpSpawnManager").GetComponent<PUSpawner>();

        if(_spawnManager == null)
        {
            Debug.LogError("The spawn manager is null");
        }
    }

    void FixedUpdate()
    {
        Move();
    }
    void Move() 
    {
        if(Input.GetAxisRaw("Horizontal") >0f) 
        {
            myBody.velocity = new Vector2(moveSpeed, myBody.velocity.y);
        }
        if(Input.GetAxisRaw("Horizontal") <0f) 
        {
            myBody.velocity = new Vector2(-moveSpeed, myBody.velocity.y);
        }
    }//move

    public void PlatformMove(float x) 
    {
        myBody.velocity = new Vector2(x, myBody.velocity.y);
    }

    public void SpeedBoostActive()
    {
        moveSpeed *= speedMultiplier;
        _isSpeedBoostActive = true;
        StartCoroutine(speedBoostPowerDownRoutine());
    }

    IEnumerator speedBoostPowerDownRoutine()
    {
        yield return new WaitForSeconds(4f);
        moveSpeed /= speedMultiplier;
        _isSpeedBoostActive = false;
    }
}//class
