using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _4LightColorChange : MonoBehaviour
{
    public float timer = 0.0f;
    
    void Update()
    {
        timer += Time.deltaTime;
        if(timer < 3){
            GetComponent<Light>().color = Color.red;
        }else if (timer < 6){
            GetComponent<Light>().color = Color.blue;
        }else if(timer < 9){
            GetComponent<Light>().color = Color.green;
        }else{
            timer = 0.0f;
        }
    }
}
