using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public float speed;
    public PlayerMove playerMove;
    public GameObject get_comp;
    
    private bool moveForward;
    private bool moveRight;
    private bool moveLeft;
    // Start is called before the first frame update
    void Start()
    {
        playerMove = get_comp.GetComponent<PlayerMove>();
        //moveForward = playerMove.moveForward;
    }

    // Update is called once per frame
    void Update()
    {
        speed = playerMove.speed;
    }
}
