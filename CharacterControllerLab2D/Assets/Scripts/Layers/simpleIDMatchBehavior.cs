using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class simpleIDMatchBehavior : MonoBehaviour
{
    public Id id;
    public UnityEvent matchEvent, noMatchEvent;

    private void OnTriggerEnter(Collider other)
    {
        
        var otherID = other.GetComponent<SimpleIdBehavior>();
        
        if (otherID.id == id)
        {
            matchEvent.Invoke();
            
        }
        else
        {
            noMatchEvent.Invoke();
            
        }
    }
}

