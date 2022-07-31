using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate1 : MonoBehaviour
{

    public GameObject initcenter;

    public Vector3 center;
    
    // Start is called before the first frame update
    void Start()
    {
        initcenter = transform.Find("center").gameObject;
        center = initcenter.transform.position;
        Destroy(initcenter.gameObject);

    }

    void Update()
    {
        //W increase the diameter S decrease the diameter
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W pressed.");
            center += (center - transform.position).normalized * 0.05f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("S pressed");
            if ((transform.position - center).magnitude > 0.05f)
            {
                center += (transform.position - center).normalized * 0.05f;
            }
        }
    }
    void FixedUpdate()
    {
        transform.RotateAround(center,Vector3.up,50*Time.deltaTime);
    }
}
