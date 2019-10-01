using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _9LookAt : MonoBehaviour
{
    public Transform target;
   
    void OnTriggerStay(Collider other)
    {
        if (other.transform == target)
        {
            //transform.LookAt(target);
            Quaternion lookOnlook =
                Quaternion.LookRotation(target.transform.position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookOnlook, Time.deltaTime);
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.transform.tag == "bullet")
        {
            Destroy(gameObject);
        }
    }
}
