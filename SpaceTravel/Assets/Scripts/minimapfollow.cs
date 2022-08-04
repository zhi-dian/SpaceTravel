using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimapfollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform follow;
    

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(follow.position.x,200f,follow.position.z);
    }
}
