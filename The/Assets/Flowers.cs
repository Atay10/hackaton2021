using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Flower
{
    private GameObject A;
    public Flower(GameObject a) {A = a;}
    private int state = 1;
    List<int> price = new List<int>() { 30, 20, 30};
    public int take_state()
    {
        return state;
    }
    public int output_state_price()
    {
        return price[state - 1];
    }
    public void up_state()
    {
        state++;
    }
    public GameObject take_flower() { return A; }
}

public class Flowers : MonoBehaviour
{

    public Button AddFlower;
    public GameObject Button1;
    public Text balance_output;
    public int balance = 30;
    public int count=0;
    public GameObject sampleObject;
    public Canvas C;
    private int x = 0;
    private int y = 0;
    List<Flower> list = new List<Flower>();
    public int[,] coords = new int[2, 10];
    List<GameObject> list_button = new List<GameObject>();
    List<bool> if_button = new List<bool>() { true };
    public void Add_flower()
    {
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
        x = coords[0, count];
        y = coords[1, count];
        count++;
        if (balance > 0)
        {
            GameObject A = Instantiate(sampleObject, sampleObject.transform.position = new Vector3(x, y, 0), Quaternion.identity) as GameObject;
            A.transform.SetParent(C.transform, false);
            Flower exemp = new Flower(A);
            list.Add(exemp);
            balance -= exemp.output_state_price();
            balance_output.text = $"{balance}";
        }

    } 
    public void Change_level()
    {

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (balance < 1000)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (if_button[i] == true)
                {
                    x = coords[0, i];
                    y = coords[1, i];
                    GameObject A = Instantiate(Button1, Button1.transform.position = new Vector3(x, y, 0), Quaternion.identity) as GameObject;
                    A.transform.SetParent(C.transform, false);
                    list_button.Add(A);
                    if_button[i] = false;
                    if_button.Add(true);
                }
            }
        }
    }
}
