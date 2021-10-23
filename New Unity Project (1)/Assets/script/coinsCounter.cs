using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinsCounter : MonoBehaviour
{
    // Start is called before the first frame update
    public static int coinsCount;
    private Text coinsTextCounter;
    void Start()
    {
        coinsTextCounter = GetComponent<Text>();
        coinsCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        coinsTextCounter.text = coinsCount.ToString();
    }
    
}
