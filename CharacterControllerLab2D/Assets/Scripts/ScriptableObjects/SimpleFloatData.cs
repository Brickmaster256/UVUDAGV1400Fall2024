using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Single variables/SimpleFloatData")]
public class SimpleFloatData : ScriptableObject
{
    public float maxValue;
    public float value;

    public void UpdateValue(float amount)
    {
        value += amount;
        if (value > maxValue)
        {
            value = maxValue;
        }
    }

    public void SetValue(float amount)
    {
        value = amount;
    }

}
