using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttactObject : MonoBehaviour
{

    public Transform hands;

    public void OnTriggerEnter(Collider other)
    {
        
        transform.parent = hands.transform;
        
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && transform.parent != null)
        {
            transform.parent = null;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        transform.parent = null;
    }
}
