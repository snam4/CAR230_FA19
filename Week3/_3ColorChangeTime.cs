using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _3ColorChangeTime : MonoBehaviour
{
    public float timer = 0.0f;
    //public Color color1;
    //public Color color2;
    //public Color color3;
    public float red =0.0f;
    public float blue = 0.0f;
    public float green = 0.0f;

    void Update()
    {
        timer = timer + Time.deltaTime; // timer +=Time.deltaTime;   
        if (timer < 3)
        {
            red = red + Time.deltaTime / 3;
            GetComponent<Renderer>().material.color = new Vector4(red,green,blue);
        }else if(timer < 6)
        {   
            green +=  Time.deltaTime / 3;
            GetComponent<Renderer>().material.color = Color.red;
        }
        else if(timer < 9)
        {
            blue += Time.deltaTime / 3;
            GetComponent<Renderer>().material.color = new Vector4(red, green, blue);
        }
        else
        {
            timer = 0.0f;
            red = 0.0f;
            green = 0.0f;
            blue = 0.0f;
        }
    }
}
