using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey(KeyCode.I))
        {
            transform.position -= Vector3.forward * 1 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.K))
        {
            transform.position -= Vector3.back * 1 * Time.deltaTime;
            { }
        }
    }
}
            