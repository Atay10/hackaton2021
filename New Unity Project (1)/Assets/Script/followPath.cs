using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPath : MonoBehaviour
{
    public movingPath myPath;
    public float speed = 1;
    public float maxDistance = 1f;
    public IEnumerator<Transform> pointInPath;
    public float startWaitTime;
    public float waitTime;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
        if (myPath == null) { return; }
        pointInPath = myPath.getNextPoint();
        pointInPath.MoveNext();

        if (pointInPath.Current == null) { return; }
        transform.position = pointInPath.Current.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (waitTime <= 0)
        {
            if (pointInPath == null || pointInPath.Current == null)
            { return; }
            transform.position = Vector3.MoveTowards(transform.position, pointInPath.Current.position, Time.deltaTime * speed);



            var distanceSquare = (transform.position - pointInPath.Current.position).sqrMagnitude;
            if (distanceSquare < maxDistance * maxDistance)
            {
               Move();
            }
            
        }
        else { waitTime = waitTime - Time.deltaTime; }
        
       
    }
    void Move() 
    {
        pointInPath.MoveNext();
        waitTime = Random.Range(1, 4);
    }
}
