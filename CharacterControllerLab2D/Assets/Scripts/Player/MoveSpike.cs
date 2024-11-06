using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpike : MonoBehaviour
{
    public float bulletSpeed = 3f;
    private int liveTime = 0;
    public GameObject dirrection;
    private void Start()
    {
        dirrection = GameObject.FindWithTag("Player");
       
        if(dirrection.GetComponent<AttackController>().lastDirectionInput == 1)
        {
            bulletSpeed *= 1;
        }
        else
        {
            bulletSpeed *= -1;
        }
       
    }

    void Update()
    {
        transform.position += new Vector3(bulletSpeed, 0, 0);
        liveTime += 1;


        if (liveTime >= 500)
        {
            Destroy(this.gameObject);
        }

    }
}
