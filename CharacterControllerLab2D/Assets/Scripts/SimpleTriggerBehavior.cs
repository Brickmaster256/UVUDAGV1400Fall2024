using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleTriggerBehavior : MonoBehaviour
{
    public UnityEvent triggerEvent;


    private void OnTriggerEnter(Collider other)
    {
        triggerEvent.Invoke();
        Debug.Log("Plater interacted with the object!");
    }
}
