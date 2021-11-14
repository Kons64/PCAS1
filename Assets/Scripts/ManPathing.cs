using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManPathing : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject[] wayPoints;
    int current = 0;
    public float speed;
    public GameObject stopPoint;
    public float stopTime;
    private float update = 0.0f;
    
    void Update()
    {
        if (transform.position != wayPoints[current].transform.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, wayPoints[current].transform.position, Time.deltaTime * speed);
        }
        else
        {
            if (stopPoint != null)
            {
                if (transform.position == stopPoint.transform.position)
                {
                    if (update < stopTime)
                    {
                        update += Time.deltaTime;
                        return;
                    }
                }
            }
           
            if (current < wayPoints.Length - 1)
            {
                current += 1;
            }
        }
    }
}
