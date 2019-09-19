using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _7PlayerNav : MonoBehaviour
{
    public int score;
    void Update()
    {
        float h = Input.GetAxis("Horizontal"); // - 1 to 1 (a,d & left, right)
        float v = Input.GetAxis("Vertical");  // - 1 to 1 (w,s & up, down)

        // Debug.Log("hor : " + h + ", ver: " + v);
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
        if(col.gameObject.tag == "coin")
        {
            score++;
            Debug.Log(score);
        }
    }

}
