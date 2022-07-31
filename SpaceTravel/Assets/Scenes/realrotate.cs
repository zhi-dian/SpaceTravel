using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class realrotate : MonoBehaviour
{
    public Vector3 velocity;

    public Vector3 center;

    public Vector3 force;

    private Vector3 distance;

    public float control = 0.05f;

    public float GMm = 5000;
    private Rigidbody rb;
    
    
    // Start is called before the first frame update
    void Start()
    {
        center = GameObject.Find("Star").transform.position;
        rb = GetComponent<Rigidbody>();
//        velocity =new Vector3(0, 0, 8);
        rb.velocity = velocity;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ForceUpdate();
        velocity = rb.velocity;
        SpeedUpdate();
    }

    void ForceUpdate()
    {
        distance = center - transform.position;
        force = distance.normalized * GMm / (distance.magnitude * distance.magnitude);
        rb.AddForce(force,ForceMode.Force);
    }

    void SpeedUpdate()
    {
        //W increase, S decrease
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W pressed");
            rb.velocity += rb.velocity.normalized * control;
        }

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("S pressed");
            rb.velocity -= rb.velocity.normalized * control;
        }
    }
}
