using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSaws : MonoBehaviour
{
    [SerializeField] private float yRange;
    [SerializeField] private float xRange;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var y = 0f;
        var x = 0f;

        if (yRange > 0)
        {
            y = Mathf.PingPong(Time.time, yRange);
        }
        if(xRange > 0)
        {
            x = Mathf.PingPong(Time.time, xRange);
        }
        var p = new Vector3(x, y, 0);
        transform.position = p;
    }
}
