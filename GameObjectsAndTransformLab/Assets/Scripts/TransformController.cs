using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{
    private void Update()
    {
        var y = Mathf.PingPong(Time.time, 3);
        var z = Mathf.Cos(Time.time * 5);
        var x = Mathf.Tan(Time.time * 2);
        var p = new Vector3(x, y, z);
        transform.position = p;

        transform.Rotate( new Vector3(30, 30, 30) * Time.deltaTime);
    }
}
