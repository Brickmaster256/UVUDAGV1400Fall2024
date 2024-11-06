using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Globalization;


[RequireComponent(typeof(TextMeshProUGUI))]
public class SimpleTextMeshProBehavior : MonoBehaviour
{
    private TextMeshProUGUI textObj;
    public ScoreBehavior Score;


    private void Start()
    {
        textObj = GetComponent<TextMeshProUGUI>();
        UpdateWithIntData();
    }

    private void Update()
    {
        UpdateWithIntData();
    }
    public void UpdateWithIntData()
    {
        
        textObj.text = "Score: " + Score.score.ToString(CultureInfo.InvariantCulture);
    }
}
