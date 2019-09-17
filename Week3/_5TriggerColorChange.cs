using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _5TriggerColorChange : MonoBehaviour
{
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }
    void OnTriggerEnter(Collider other) 
    {
        GetComponent<Renderer>().material.color = Color.yellow;
    }
    void OnTriggerExit(Collider other)
    {
        GetComponent<Renderer>().material.color = Color.white;
    }
}
