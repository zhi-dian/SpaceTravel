using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DataOverlay : MonoBehaviour
{
    public TextMeshProUGUI speed;

    public TextMeshProUGUI dist;

    public TextMeshProUGUI posx, posz;

    public TextMeshProUGUI tarx, tarz;
    

    public GameObject ship;

    public GameObject target;

    private float distance;

    private float newspeed;

    private float positionx, positionz, targetx, targetz;
    // Start is called before the first frame update
    void Start()
    {
        newspeed = 0;
        distance = 0;
        ship = GameObject.Find("Cube").gameObject;
        target = GameObject.Find("windetect0").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        newspeed = ship.GetComponent<realrotate>().velocity.magnitude;
        distance = ship.GetComponent<realrotate>().distance.magnitude;
        positionx = ship.transform.position.x;
        positionz = ship.transform.position.z;
        targetx = target.transform.position.x;
        targetz = target.transform.position.z;
        
        speed.text = newspeed.ToString("f3");
        dist.text = distance.ToString("f3");
        posx.text = positionx.ToString("f1");
        posz.text = positionz.ToString("f1");
        tarx.text = targetx.ToString("f1");
        tarz.text = targetz.ToString("f1");
    }
}
