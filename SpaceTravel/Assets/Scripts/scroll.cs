using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
    public Camera map;
    public GameObject pointer;
    public GameObject winpointer;

    private void Start()
    {
        pointer = GameObject.Find("pointer").gameObject;
        winpointer = GameObject.Find("winpointer").gameObject;

    }

    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (map.orthographicSize < 1000)
            {
                map.orthographicSize *= 2;
                pointer.transform.localScale *= 2;
                winpointer.transform.localScale *= 2;
            }
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {

            if (map.orthographicSize > 5)
            {
                map.orthographicSize /= 2;
                pointer.transform.localScale /= 2;
                winpointer.transform.localScale /= 2;
            }
        }
    }
}
