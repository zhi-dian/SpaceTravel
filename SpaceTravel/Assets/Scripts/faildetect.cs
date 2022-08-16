using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faildetect : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject failpattern;
    public GameObject pause;
    // Start is called before the first frame update
    private void Start()
    {
        failpattern = GameObject.Find("Canvas").transform.Find("Fail").gameObject;
        pause = GameObject.Find("Canvas").transform.Find("PauseButton").gameObject;
        
    }


    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ship"))
        {
            pause.SetActive(false);
            failpattern.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
