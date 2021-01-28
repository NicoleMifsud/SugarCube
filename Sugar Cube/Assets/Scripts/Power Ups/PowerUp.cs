using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3f;

    [SerializeField]
    private int _powerupID;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * _speed);
        //if the powerup position on the y axis is smaller than -6f destroy the powerup
        if(transform.position.y < -6f)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();
            if(player != null)
            {
                switch(_powerupID)
                {
                    case 0:
                        player.SpeedBoostActive();
                        Debug.Log("_speed Boost Activated");
                        break;

                    case 1:
                        //player.SpeedBoostActive();
                        Debug.Log("_speed Boost Activated");
                        break;

                    default:
                        Debug.Log("Default Value");
                        break;

                }
            }
            Destroy(this.gameObject);
        }
    }
}
