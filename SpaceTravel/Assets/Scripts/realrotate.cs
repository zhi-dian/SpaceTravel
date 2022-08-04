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
    
    /*    
    [Header("Cinemachine")]
    [Tooltip("The follow target set in the Cinemachine Virtual Camera that the camera will follow")]
    public GameObject CinemachineCameraTarget;

    [Tooltip("How far in degrees can you move the camera up")]
    public float TopClamp = 70.0f;

    [Tooltip("How far in degrees can you move the camera down")]
    public float BottomClamp = -30.0f;

    [Tooltip("Additional degress to override the camera. Useful for fine tuning camera position when locked")]
    public float CameraAngleOverride = 0.0f;

    [Tooltip("For locking the camera position on all axis")]
    public bool LockCameraPosition = false;

    private StarterAssetsInputs _input;
    private GameObject _mainCamera;

    private const float _threshold = 0.01f;
    private float _cinemachineTargetYaw;
    private float _cinemachineTargetPitch;
    // Start is called before the first frame update
    
    */
    void Start()
    {
        rb = GetComponent<Rigidbody>();
//        velocity =new Vector3(0, 0, 8);
        rb.velocity = velocity;
     /*   
        if (_mainCamera == null)
        {
            _mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        }
        */
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
            rb.velocity -= rb.velocity.normalized * control;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("trigger!!");
        target = collision.transform.parent.gameObject;
        center = target.transform.position;
        GMm = target.GetComponent<starproperty>().GMm;
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
