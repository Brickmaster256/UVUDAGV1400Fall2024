using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class SimpleImageBehavior : MonoBehaviour
{
    private Image imageObj;
    public SimpleFloatData dataObj;

    private void Start()
    {
        Image imageObj = GetComponent<Image>();
        Debug.Log(imageObj);
    }

    public void UpdateWithFloatData()
    {
        Debug.Log(dataObj);
        imageObj.fillAmount = dataObj.value;
    }
}
