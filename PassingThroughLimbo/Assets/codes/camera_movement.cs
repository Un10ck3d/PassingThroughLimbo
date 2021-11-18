using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movement : MonoBehaviour
{
    public GameObject get_code;
    public float shacking;
    public float speed_movement;
    public PlayerMove speed_lol;
    private float just_speed;

    void Start()
    {
        speed_lol = get_code.GetComponent<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        just_speed = speed_lol.speed_dir;
        just_speed = just_speed / 10;
        if (just_speed > 0.1)
        {
            transform.position = new Vector3(-just_speed,0,-10);
        }
        if (just_speed < 0.1)
        {
            //transform.position = new Vector3(0,0,-10);
        }
    }
}
