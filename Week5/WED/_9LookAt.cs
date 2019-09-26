using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _9LookAt : MonoBehaviour
{
    public Transform target;
    
    void OnTriggerStay(Collider other)
    {
        //transform.LookAt(target);
        Quaternion lookOnLook =
            Quaternion.LookRotation(target.transform.position - transform.position);

        transform.rotation = Quaternion.Slerp(transform.rotation, lookOnLook, Time.deltaTime);
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
