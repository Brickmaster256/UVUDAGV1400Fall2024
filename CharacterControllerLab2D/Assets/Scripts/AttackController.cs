using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    public GameObject ThrowAttack;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(ThrowAttack, new Vector3(0, 0, 0), Quaternion.identity);)
        }
    }
}
