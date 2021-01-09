using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{

    public float move_Speed = 2f;
    public float bound_Y = 6f;

    public bool moving_Platform_Left, moving_Platform_Right, is_Platform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move() {
        Vector2 temp = transform.position;
        temp.y += move_Speed * Time.deltaTime;
        transform.position = temp;

        if(temp.y >= bound_Y) {
            gameObject.SetActive(false);
        }
    }
}
