using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthContainer : MonoBehaviour
{
    public SimpleFloatData HealthData;
    
    public void ReduceHealth(float amount)
    {
        HealthData.UpdateValue(amount);
    }
}