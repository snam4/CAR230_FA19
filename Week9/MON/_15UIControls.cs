using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _15UIControls : MonoBehaviour
{
    public Image keyImg;
    public Sprite keyBW;
    public Sprite keyColor;
    public bool hasKey;

    void Start()
    {
        keyImg = GameObject.Find("KeyImage").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        hasKey = GameObject.FindWithTag("Player").GetComponent<_13PlayerInventory>().hasKey;
        if(hasKey == true)
        {
            keyImg.sprite = keyColor;
        }
        else
        {
            keyImg.sprite = keyBW;
        }
    }
}
