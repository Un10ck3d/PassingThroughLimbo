using UnityEngine;

public class camera_movement : MonoBehaviour
{
    public Transform follow;
    public PlayerMove hell;
    private Vector3 pos;
    public float smooth_speed;
    public Vector3 offset;
    public GameObject get_comp;
    public float speed2;
    void start ()
    {
        hell = get_comp.GetComponent<PlayerMove>();
    }
    void FixedUpdate()
    {
        speed2 = hell.speed;
        speed2 = -speed2 / 25;
        Vector3 despot = follow.position + offset;
        Vector3 smoothpos = Vector3.Lerp (transform.position, despot, smooth_speed);
        smoothpos.z = smoothpos.z += speed2;
        transform.position = smoothpos;
    }
}
