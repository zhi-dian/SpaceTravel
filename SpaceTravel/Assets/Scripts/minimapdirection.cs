using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimapdirection : MonoBehaviour
{
    // Start is called before the first frame update
    public realrotate ship;
    public Transform follow;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.FromToRotation(Vector3.up,ship.velocity);
        transform.position = new Vector3(follow.position.x,10f,follow.position.z);
        //Debug.Log(ship.velocity);
    }
}
