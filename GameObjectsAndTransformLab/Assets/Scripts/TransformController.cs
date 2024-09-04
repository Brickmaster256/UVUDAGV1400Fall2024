using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{
    private void Update()
    {
        var y = Mathf.PingPong(Time.time, 3);
        //var x = Mathf.Cos(Time.time * 5);
        //var z = Mathf.Tan(Time.time * 2);
        var p = new Vector3(0, y, 0);
        transform.position = p;

        transform.Rotate( new Vector3(0, 30, 0) * Time.deltaTime);
    }
}
