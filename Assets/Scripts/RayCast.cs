using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public float detectionRange = 15f;
    public Vector3 collision = Vector3.zero;
    public LayerMask layer;
    public GameObject lastHit;
    public bool warning =false;
    public static RayCast rayCast;

    private void Start()
    {
        rayCast = this;
        CharacterController charContr = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Cast character controller shape 10 meters forward to see if it is about to hit anything.
        //if (Physics.CapsuleCast(this.transform.position + Vector3.up, this.transform.position + Vector3.up, 0.65f, transform.forward, 20f, layer))
        if (OnDetect(0.65f, detectionRange))
        {
            warning = true;
        }
        else
        {
            warning = false;
        }

    }
    bool OnDetect(float radius, float distance) 
    {
        if (Physics.CapsuleCast(this.transform.position + Vector3.up, this.transform.position + Vector3.up, radius, transform.forward, distance, layer)
            || Physics.CapsuleCast(this.transform.position + Vector3.up, this.transform.position + Vector3.up, radius, Quaternion.AngleAxis(-9, new Vector3(0, 1, 0)) * transform.forward, distance, layer)
            || Physics.CapsuleCast(this.transform.position + Vector3.up, this.transform.position + Vector3.up, radius, Quaternion.AngleAxis(9, new Vector3(0, 1, 0))* transform.forward, distance, layer))
        {
            return true;
        }
        return false;
    }
    
}
