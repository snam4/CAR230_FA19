using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _8Instantiate : MonoBehaviour
{
    public GameObject coin;
    public Vector3 charPos;
    public Vector3 position;
    void Start()
    {
        charPos = GameObject.Find("Player").transform.position;
        for (int i = 0;i <10; i++)
        {
            position = new Vector3(
                Random.Range(charPos.x - 50.0f, charPos.x + 50.0f),
                charPos.y, Random.Range(charPos.z - 50.0f, charPos.z + 50.0f));
            Instantiate(coin, position, coin.transform.rotation);
        }    
    }

    
}
