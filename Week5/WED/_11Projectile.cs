using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _11Projectile : MonoBehaviour
{
    public Transform bullet;
    public GameObject weapon;
    public float timer;
    public float nextFire;

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Instantiate(bullet, weapon.transform.position, weapon.transform.rotation);
        }
    }
}
