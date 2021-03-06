using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolUP : MonoBehaviour
{

    public GameObject[] PathNode;
    public GameObject Player;
    public float MoveSpeed;
    float Timer;
    static Vector3 CurrentPositionHolder;
    int CurrentNode;
    private Vector2 startPosition;
    private float waitTime;
    public float startWaitTime;


    // Use this for initialization
    void Start()
    {
        waitTime = startWaitTime;
        //PathNode = GetComponentInChildren<>();
        CheckNode();
    }

    void CheckNode()
    {
        Timer = 0;
        startPosition = Player.transform.position;
        CurrentPositionHolder = PathNode[CurrentNode].transform.position;
        waitTime = Random.Range(1, 4);
    }

    // Update is called once per frame
    void Update()
    {

        Timer += Time.deltaTime * MoveSpeed;

        if (Player.transform.position != CurrentPositionHolder)
        {
            Player.transform.position = Vector3.Lerp(startPosition, CurrentPositionHolder,  Timer);
            
        }
        else
        {

            if (CurrentNode < PathNode.Length - 3)
            {
                
                if (waitTime <= 0)
                {
                    CurrentNode++;
                    CheckNode();
                }
                else { waitTime = waitTime - Time.deltaTime; }

                
            }
        }
    }

    
}