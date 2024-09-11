using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BouncyBall : MonoBehaviour
{
    public float bounceForce = 3f;
    public Color firstColor = Color.red;
    public Color secondColor = Color.green;
    public Color thirdColor = Color.blue;

    private void Start()
    {
        setColor(firstColor);  
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
        bounceForce /= 1.2f;
        if (bounceForce < 0.01)
        {
            bounceForce = 0f;
        }
        if(GetComponent<Renderer>().material.color == firstColor) 
        {
            setColor(secondColor);
        }
        else if (GetComponent<Renderer>().material.color == secondColor)
        {
            setColor(thirdColor);
        }
        else if (GetComponent<Renderer>().material.color == thirdColor)
        {
            setColor(firstColor);
        }
    }

    private void setColor(Color color)
    {
        GetComponent <Renderer>().material.color = color;
    }
}
