using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform target;

    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.position -= Vector3.forward * 1 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
           transform.position -= Vector3.back * 1 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 relativePos = target.position - transform.position;
            transform.rotation = Quaternion.LookRotation(relativePos);
        }
    }

}

