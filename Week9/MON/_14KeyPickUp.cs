using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _14KeyPickUp : MonoBehaviour
{
    public GameObject player;
    public _13PlayerInventory pInventory;
    public AudioSource powerUpSound;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        pInventory = player.GetComponent<_13PlayerInventory>();
        powerUpSound = GetComponent<AudioSource>(); 
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            pInventory.hasKey = true;
            powerUpSound.Play();
            Destroy(gameObject,5);
        }
    }
}
