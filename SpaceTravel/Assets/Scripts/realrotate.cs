using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class realrotate : MonoBehaviour
{
    //data for rotation
    public Vector3 center;

    public Vector3 force;

    public Vector3 distance;

    public float GMm = 5000;
    //data for rotation
    
    public Vector3 velocity;
    
    public float control = 0.05f;

    
    private Rigidbody rb;

    public GameObject target = null;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
//        velocity =new Vector3(0, 0, 8);
        rb.velocity = velocity;
     
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (target)
        {
            ForceUpdate();
        }
        velocity = rb.velocity;
        SpeedUpdate();
        
    }

    void ForceUpdate()
    {
        distance = center - transform.position;
        force = distance.normalized * GMm / (distance.magnitude * distance.magnitude);
        rb.AddForce(force,ForceMode.Force);
    }

    void SpeedUpdate()
    {
        //W increase, S decrease
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W pressed");
            rb.velocity += rb.velocity.normalized * control;
        }

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("S pressed");
            if(rb.velocity.magnitude > 0.5) rb.velocity -= rb.velocity.normalized * control;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Field"))
        {
            Debug.Log("trigger!!");
            target = collision.transform.parent.gameObject;
            center = target.transform.position;
            GMm = target.GetComponent<starproperty>().GMm;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exist!!");
        target = null;
    }
    
    /*
    private bool IsCurrentDeviceMouse
    {
        get
        {
#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
                return _playerInput.currentControlScheme == "KeyboardMouse";
#else
            return false;
#endif
        }
    }
    

    private void CameraRotation()
    {
        // if there is an input and camera position is not fixed
        if (_input.look.sqrMagnitude >= _threshold && !LockCameraPosition)
        {
            //Don't multiply mouse input by Time.deltaTime;
            float deltaTimeMultiplier = IsCurrentDeviceMouse ? 1.0f : Time.deltaTime;

            _cinemachineTargetYaw += _input.look.x * deltaTimeMultiplier;
            _cinemachineTargetPitch += _input.look.y * deltaTimeMultiplier;
        }

        // clamp our rotations so our values are limited 360 degrees
        _cinemachineTargetYaw = ClampAngle(_cinemachineTargetYaw, float.MinValue, float.MaxValue);
        _cinemachineTargetPitch = ClampAngle(_cinemachineTargetPitch, BottomClamp, TopClamp);

        // Cinemachine will follow this target
        CinemachineCameraTarget.transform.rotation = Quaternion.Euler(_cinemachineTargetPitch + CameraAngleOverride,
            _cinemachineTargetYaw, 0.0f);
    }
    
    private static float ClampAngle(float lfAngle, float lfMin, float lfMax)
    {
        if (lfAngle < -360f) lfAngle += 360f;
        if (lfAngle > 360f) lfAngle -= 360f;
        return Mathf.Clamp(lfAngle, lfMin, lfMax);
    }
    */
}
