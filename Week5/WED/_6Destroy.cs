using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _6Destroy : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * 60); 
    }
    void OnCollisionEnter(Collision col) //OnTriggerEnter (Collider other)
    {
        Destroy(gameObject);
    }
}
