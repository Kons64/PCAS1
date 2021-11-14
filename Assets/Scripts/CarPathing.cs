using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarPathing : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject wayPoint;
    public float speed;
    public float acceleration = 0f;
    private float update = 0f;

    [Header("Set Dynamically")]
    private float initialSpeed;
    public static CarPathing carPathing;
    private void Start()
    {
        initialSpeed = speed;
        carPathing = this;
    }
    void Update()
    {
        update += Time.deltaTime;
        if (update > 0.1f)
        {
            update = 0.0f;
            if (RayCast.rayCast.warning)
            {
                ApplyBrake();
            }
            else 
            {
                if (speed < initialSpeed)
                {
                    ApplyAcceleration();
                }
            }
            
        }
        if (Vector3.Distance(wayPoint.transform.position, transform.position) > 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, wayPoint.transform.position, Time.deltaTime * speed);
        }
    }

    void ApplyBrake() 
    {
        if (acceleration < 6.867f)
        {
            acceleration -= 3.4335f;
        }
        else
        {
            acceleration = -6.867f;
        }
        speed += acceleration/10;
        if (speed < 0)
        {
            speed = 0;
            acceleration = 0;
        }
    }

    void ApplyAcceleration() 
    {
        acceleration = 2.4525f;
        speed += acceleration / 10;
        if (speed >= initialSpeed)
        {
            acceleration = 0;
            speed = initialSpeed;
        }
    }
}
