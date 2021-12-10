using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoothing_mechanic : MonoBehaviour
{
    //this code should be set on the rotating gun or arm
    public Transform fire_point;
    public GameObject get_prefab;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            shoot();
        }
    }
    void shoot()
    {
        Instantiate(get_prefab, fire_point.position, fire_point.rotation);
    }
}
