using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movement : MonoBehaviour
{
    public float shacking;
    public float speed_movement;
    public PlayerMove speed;

    // Update is called once per frame
    void Update()
    {
        transform.position(-speed);
    }
}
