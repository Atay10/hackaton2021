using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Flowers2 : MonoBehaviour
{
    public Button AddFlower;
    public Text num;
    public int score = 0;
    public GameObject sampleObject;
    public GameObject A;
    public Canvas C;
    private int x = 0;
    private int y = 0;


    public void Add_flower()
    {
        num.text = $"{score}";
        int[,] coords = new int[2, 10];
        coords[0, 0] = -180;
        coords[1, 0] = -130;
        coords[0, 1] = -250;
        coords[1, 1] = 0;
        coords[0, 2] = -150;
        coords[1, 2] = 100;
        coords[0, 3] = 0;
        coords[1, 3] = 150;
        coords[0, 4] = 130;
        coords[1, 4] = 130;


        x = coords[0, score];
        y = coords[1, score];
        score++;
        A = Instantiate(sampleObject, sampleObject.transform.position = new Vector3(x, y, 0), Quaternion.identity) as GameObject;
        A.transform.SetParent(C.transform, false);
    }
}