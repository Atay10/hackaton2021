using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extractionPlants : MonoBehaviour
{
    public void onClick()
    {
        private int rand = Random.Range(0, 2);
        if (coinsCounter.coinsCount >= 50 && hoverColor.planting == false)
        {
            hoverColor.planting = true;
        }
        else
        { hoverColor.planting = false; }
    }
}
