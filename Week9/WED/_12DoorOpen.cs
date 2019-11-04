using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _12DoorOpen : MonoBehaviour
{
    public Animator anim;
    public GameObject player;
    public _13PlayerInventory pInventory;

    void Start()
    {
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
        pInventory = player.GetComponent<_13PlayerInventory>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player && pInventory.hasKey)
        {
            anim.SetBool("CharacterIn", true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            anim.SetBool("CharacterIn", false);
        }
    }
}
