using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extractionPlants : MonoBehaviour
{
    public void onClick()
    {
        if (coinsCounter.coinsCount >= 50 && hoverColor.planting == false)
        {
            hoverColor.planting = true;
        }
        else
        { hoverColor.planting = false; }
    }

    void OnMouseEnter()
    {
        hoverColor.planting = false;
    }

    void OnMouseExit()
    {
        hoverColor.planting = false;
    }
}
