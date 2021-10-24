using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPath : MonoBehaviour
{
    public enum pathTypes
    {
        linear,
        loop
    }
    public pathTypes pathType;
    public int movingDirection = 1;
    public int movingTo = 0;
    public Transform[] pathElements;


    public IEnumerator<Transform> getNextPoint() 
    {
        if (pathElements == null || pathElements.Length < 1) 
        {
            yield break;
        }

        while (true) 
        {
            yield return pathElements[movingTo];

            if (pathElements.Length == 1) 
            {
                continue;
            }
            if (pathType == pathTypes.linear)
            {
                if (movingTo <= 0)
                {
                    movingDirection = 1;
                }
                else if (movingTo >= pathElements.Length - 1)
                {
                    movingDirection = -1;
                }
            }

            movingTo = movingTo + movingDirection;

            if (pathType == pathTypes.loop)
            {
                if (movingTo >= pathElements.Length)
                {
                    movingTo = 0;
                }
                else if (movingTo < 0)
                {
                    movingTo = pathElements.Length - 1;
                }
            }
        }
    }
}
