using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _7CharNav : MonoBehaviour
{
    public int score = 0 ;
    void Update(){
        float h = Input.GetAxis("Horizontal"); // left, right & a,d (-1 to 1)
        float v = Input.GetAxis("Vertical"); // up , down & w,s (-1 to 1)
        transform.Translate(Vector3.forward * v * .2f);
        transform.Rotate(Vector3.up * h);
        if (Input.GetKeyDown("space")){
            Vector3 up = transform.TransformDirection(Vector3.up);
            GetComponent<Rigidbody>().AddForce(up * 5, ForceMode.Impulse);
        }
    }
    void OnCollisionEnter(Collision col){
        if (col.gameObject.tag == "coin")
        {
            score++; //score = score +1;
        }
    }

    void OnGUI()
    {
        string coinNum = score.ToString();
        GUI.Box(new Rect(10, 10, 150, 50), "Coin: ");
        GUI.Label(new Rect(75, 30, 25, 25), coinNum);
    }
}
