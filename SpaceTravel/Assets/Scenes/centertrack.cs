using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class centertrack : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    void Start()
    {
        //target = GameObject.Find("Cube(1)");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.GetComponent<rotate1>().center;
    }
}
