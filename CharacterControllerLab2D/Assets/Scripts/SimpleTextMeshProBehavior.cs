using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Globalization;


[RequireComponent(typeof(TextMeshProUGUI))]
public class SimpleTextMeshProBehavior : MonoBehaviour
{
    private TextMeshProUGUI textObj;
    public SimpleIntData dataObj;
    public ScoreBehavior Score;


    private void Start()
    {
        textObj = GetComponent<TextMeshProUGUI>();
        UpdateWithIntData();
    }

    public void UpdateWithIntData()
    {
        
        textObj.text = Score.score.ToString(CultureInfo.InvariantCulture);
    }
}
