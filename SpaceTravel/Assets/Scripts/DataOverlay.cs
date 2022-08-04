using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DataOverlay : MonoBehaviour
{
    public TextMeshProUGUI speed;

    public TextMeshProUGUI dist;

    public GameObject ship;

    private float distance;

    private float newspeed;
    // Start is called before the first frame update
    void Start()
    {
        newspeed = 0;
        distance = 0;
    }

    // Update is called once per frame
    void Update()
    {
        newspeed = ship.GetComponent<realrotate>().velocity.magnitude;
        distance = ship.GetComponent<realrotate>().distance.magnitude;
        speed.text = newspeed.ToString("f3");
        dist.text = distance.ToString("f3");
    }
}
