using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreContainer : MonoBehaviour
{
    public SimpleIntData ScoreData;
    
    public void AddPoint(int amount)
    {
        ScoreData.UpdateValue(amount);
    }
}