using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipPerson : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform target;
    private bool faceToRight = false;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target.transform.position.x < GameObject.FindGameObjectWithTag("flipToRight").GetComponent<Transform>().transform.position.x && faceToRight == false)
        {
            flip();
            faceToRight = true;
        }
        else if (target.transform.position.x > GameObject.FindGameObjectWithTag("flipToLeft").GetComponent<Transform>().transform.position.x && faceToRight == true) 
        {
            flip();
            faceToRight = false;
        }
        
    }
    void flip()
    {
            transform.Rotate(0f, 180f, 0f);
    }
    
}
