using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCollectable : MonoBehaviour
{

    private Transform thisTransform;

    // Start is called before the first frame update
    void Start()
    {
        thisTransform = transform;

    }

    // Update is called once per frame
    void Update()
    {
        var thisPosition = thisTransform.position;
        var deltaHeight = Mathf.PingPong(Time.time, 1);
        var height = new Vector3(thisPosition.x, deltaHeight, 0); 

        transform.position = height;
        transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
    }
}
