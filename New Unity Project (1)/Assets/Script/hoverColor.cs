using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoverColor : MonoBehaviour
{
    public static bool planting = false;
    public GameObject obj;
    private GameObject imagObj;
    private bool isOccupied = false;
    void OnMouseEnter()
    {
        if (planting)
        {
            imagObj = Instantiate(obj, transform.position, Quaternion.identity);
            imagObj.GetComponent<Renderer>().material.color *= 0.5f;
        }

        /*GetComponent<Renderer>().material.color = new Color(
            GetComponent<Renderer>().material.color.r + 1,
            GetComponent<Renderer>().material.color.g + 1,
            GetComponent<Renderer>().material.color.b + 1);*/
    }

    private void OnMouseUp()
    {
        if (planting && !isOccupied)
        {
            Instantiate(obj, transform.position, Quaternion.identity);
            coinsCounter.coinsCount -= 50;
            isOccupied = true;
            if (coinsCounter.coinsCount < 50) { planting = false; }
        }
    }

    void OnMouseExit()
    {
        Destroy(imagObj);

        /*GetComponent<Renderer>().material.color = new Color(
            GetComponent<Renderer>().material.color.r - 1,
            GetComponent<Renderer>().material.color.g - 1,
            GetComponent<Renderer>().material.color.b - 1);*/
    }
}
