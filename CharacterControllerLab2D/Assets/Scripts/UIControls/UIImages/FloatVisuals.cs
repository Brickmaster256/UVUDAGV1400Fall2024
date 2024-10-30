using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Globalization;
using System.ComponentModel;

[RequireComponent(typeof(TextMeshProUGUI))]
public class FloatVisuals : MonoBehaviour
{
    private TextMeshProUGUI floatText;
    public SimpleFloatData floatData;

    private void Start()
    {
        floatText = GetComponent<TextMeshProUGUI>();
        UpdateWithFloatData();
    }

    private void Update()
    {
        UpdateWithFloatData();
    }
    public void UpdateWithFloatData()
    {
        floatText.text = floatData.value.ToString(CultureInfo.InvariantCulture);
    }
}
