using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            transform.Rotate(0, 0, -10);
        }
        if(Input.GetKeyUp(KeyCode.Z))
        {
            transform.Rotate(-0, 0, 10);
        }
        if(Input.GetKeyDown(KeyCode.X))
        {
            transform.Rotate(0, 0, 10);
        }
        if(Input.GetKeyUp(KeyCode.X))
        {
            transform.Rotate(0, 0, -10);
        }
    }
}
