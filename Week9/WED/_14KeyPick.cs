using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _14KeyPick : MonoBehaviour
{
    public GameObject player;
    public _13PlayerInventory pInventory;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        pInventory = player.GetComponent<_13PlayerInventory>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            pInventory.hasKey = true;
            Destroy(gameObject);
        }
    }
}
