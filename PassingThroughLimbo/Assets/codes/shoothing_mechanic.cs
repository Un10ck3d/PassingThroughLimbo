using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoothing_mechanic : MonoBehaviour
{
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
