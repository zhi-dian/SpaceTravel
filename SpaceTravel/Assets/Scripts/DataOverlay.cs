using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DataOverlay : MonoBehaviour
{
    public TextMeshProUGUI speed;

    public TextMeshProUGUI acce;

    public GameObject ship;

    private float lastspeed;

    private float newspeed;
    // Start is called before the first frame update
    void Start()
    {
        lastspeed = 0;
        newspeed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        newspeed = ship.GetComponent<realrotate>().velocity.magnitude;
        speed.text = newspeed.ToString("f3");
        acce.text = ((newspeed - lastspeed)*100000).ToString("f3");
        lastspeed = newspeed;
    }
}
