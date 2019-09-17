using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _1Var : MonoBehaviour
{
    public int v = 1;
    public Transform GOtransform;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.Log(GOtransform.position);
    }
}
