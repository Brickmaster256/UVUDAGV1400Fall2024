using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;


public class SimpleImageBehavior : MonoBehaviour
{

    public SimpleFloatData dataObj;
    public Slider slider;
    public int startingValue = 10;

    private void Start()
    {
        SetDataValue();
    }
    public void SetDataValue()
    {
        slider.value = dataObj.value;
    }

}
