using UnityEngine;

public class camera_movement : MonoBehaviour
{
    public Transform follow;

    public float smooth_speed;
    
    public float speed = 0f;
    public Vector3 starter_Camera_size;
    public float Camera_size_range;
    private Vector3 end_Camera_size;
    public Vector2 oldPosition;
    public Vector3 offset;
    void start ()
    {
        oldPosition = transform.position;
    }
    void FixedUpdate()
    {
        speed = Vector2.Distance(oldPosition, transform.position) * -10f;
        end_Camera_size.z = starter_Camera_size.z += speed;
        Vector3 despot = follow.position + end_Camera_size;
        Vector3 smoothpos = Vector3.Lerp (transform.position, despot, smooth_speed);
        transform.position = smoothpos;
        oldPosition = transform.position;
    }
}
