using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _11Projectile : MonoBehaviour
{
    public Transform bullet;
    public GameObject weapon;
    public float timer = 0.0f;
    public float nextFire = 0.5f;

    void Update()
    {
        timer += Time.deltaTime; 
        if (Input.GetButton("Fire1") && timer > nextFire)
        {
            Instantiate(bullet, weapon.transform.position, weapon.transform.rotation);
            timer = 0.0f;
        }
    }
}
