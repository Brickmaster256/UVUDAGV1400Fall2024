using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;


public class SimpleImageBehavior : MonoBehaviour
{

    public SimpleFloatData dataObj;
    public Slider slider;
    public int health = 10;

    
    public void SetDataValue()
    {
        slider.value = dataObj.value;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            dataObj.value = health;
            SetDataValue();
        }
    }
}
