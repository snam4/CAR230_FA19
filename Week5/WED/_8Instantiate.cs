using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _8Instantiate : MonoBehaviour
{
    public GameObject coin;
    public Vector3 charPos;
    public Vector3 coinPos;
    void Start()
    {
        charPos = GameObject.Find("Player").transform.position; 
        for(int i = 0; i <30; i++)
        {
            coinPos = new Vector3(Random.Range(charPos.x - 5.0f, charPos.x + 5.0f),
                charPos.y, Random.Range(charPos.z - 5.0f, charPos.z + 5.0f));
            Instantiate(coin, coinPos, coin.transform.rotation);
        }
    }
}
