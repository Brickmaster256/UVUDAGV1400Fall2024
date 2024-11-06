using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Single variables/ScoreBehavior")]
public class ScoreBehavior : ScriptableObject
{
    public int score;

    public void SetScore(int amount)
    {
        score = amount;
    }
    public void UpdateScore(int amount)
    {
        score += amount;
    }
}
