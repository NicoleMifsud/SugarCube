using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpawner : MonoBehaviour
{
    // [SerializeField]
    // private GameObject[] _powerups;

    // private bool _stopSpawning = false;

    // // Start is called before the first frame update
    // void Start()
    // {
    //     StartCoroutine(SpawnPowerupRoutine());
    // }

    // // Update is called once per frame
    // void Update()
    // {

    // }
    
    // IEnumerator SpawnPowerupRoutine()
    // {
    //     while(_stopSpawning == false)
    //     {
    //         Vector3 posToSpawn = new Vector3(Random.Range(-2.4f,2.4f),4f,0);
    //         int randomPowerup = Random.Range(0,_powerups.Length);
    //         Instantiate(_powerups[randomPowerup],posToSpawn,Quaternion.identity);
    //         yield return new WaitForSeconds(Random.Range(6,10));
    //     }
    // }

    // public void OnPlayerDeath()
    // {
    //     _stopSpawning = true;
    // }
}//class
