using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AttackController : MonoBehaviour
{
    public GameObject ThrowAttack;
    public SimpleFloatData manaAmount;
    
    public SimpleImageBehavior manaImageBehavior;
    public FloatVisuals manaPoints;

    public int lastDirectionInput = 1;
    private int directionOfBullet = -90;

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            lastDirectionInput = 1;
        }
        else if(Input.GetKeyDown(KeyCode.A))
        {
            lastDirectionInput = -1;
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            if(manaAmount.value > 0)
            {
                if (lastDirectionInput == 1)
                {
                    directionOfBullet = -90;
                }
                else
                {
                    directionOfBullet = 90;
                }
                Instantiate(ThrowAttack, transform.position, Quaternion.Euler(0,0,directionOfBullet));
                manaAmount.UpdateValue(-1);
                manaImageBehavior.SetDataValue();
                manaPoints.UpdateWithFloatData();
            }
            
        }
    }
}
