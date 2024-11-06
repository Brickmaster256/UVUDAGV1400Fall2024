using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleTriggerBehavior : MonoBehaviour
{
    public UnityEvent triggerEvent;
    public float pausetime = .5f;
    

    private void OnTriggerEnter(Collider other)
    {
        triggerEvent.Invoke();
        StartCoroutine(PauseBetweenTriggers());
    }

    private IEnumerator PauseBetweenTriggers()
    {
        yield return new WaitForSeconds(pausetime);
    }
}
