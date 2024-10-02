using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpike : MonoBehaviour
{
    public float bulletSpeed = 3f;
    void Update()
    {
       
        transform.position += new Vector3(bulletSpeed, 0, 0);
    }
}
