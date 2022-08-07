using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
    public Camera map;
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            map.orthographicSize *= 2;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            map.orthographicSize /= 2;
        }
    }
}
