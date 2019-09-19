using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _6Destroy : MonoBehaviour
{
    void OnCollisionEnter(Collision other) //void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other);
        Destroy(gameObject);
    }
}
