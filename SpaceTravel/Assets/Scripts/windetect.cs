using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windetect : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject winpattern;
    public GameObject pause;

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ship"))
        {
            pause.SetActive(false);
            winpattern.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
