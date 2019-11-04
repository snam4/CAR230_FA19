using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _16DoorOpenAnimation : MonoBehaviour
{
    public Animator anim;
    public bool hasKey;
    public Text keyQuestion;

    void Start()
    {
        anim = GetComponent<Animator>();
        keyQuestion.enabled = false;
    }
    void Update()
    {
        hasKey = GameObject.FindWithTag("Player").GetComponent<_13PlayerInventory>().hasKey;
    }
    void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag == "Player" && hasKey )
        {
            anim.SetBool("CharacterIn", true);
        }
        else
        {
            keyQuestion.enabled = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            anim.SetBool("CharacterIn", false);
            keyQuestion.enabled = false;
        }
    }
}
