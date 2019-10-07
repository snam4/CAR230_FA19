using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _7CharNav : MonoBehaviour
{
    public int score = 0;
    public int hp = 10;
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * v * 0.05f);
        transform.Rotate(Vector3.up * h);

        if (Input.GetKeyDown("space"))
        {
            Vector3 up = transform.TransformDirection(Vector3.up);
            GetComponent<Rigidbody>().AddForce(up * 5, ForceMode.Impulse);
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Coin")
        {
            score++; // score = score +1;
        }

        if (col.gameObject.tag == "enemy")
        {
            hp --; // score = score +1;
        }
    }
    void OnGUI()
    {
        string coinNum = score.ToString();
        string hpNum = hp.ToString();
        GUI.Box(new Rect(10, 10, 150, 50), "Coin : ");
        GUI.Label(new Rect(75, 30, 25, 25), coinNum);

        GUI.Box(new Rect(170, 10, 150, 50), "HP : ");
        GUI.Label(new Rect(250, 30, 25, 25), hpNum);
    }
}
