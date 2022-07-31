using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject center;
    public float velocity = 2;
    void Start()
    {
        center = GameObject.Find("Sun");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.RotateAround(center.transform.position,Vector3.up,velocity*Time.deltaTime);
    }
}
