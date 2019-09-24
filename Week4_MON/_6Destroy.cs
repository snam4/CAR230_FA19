using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _6Destroy : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * 50);
    }
    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
}
