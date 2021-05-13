using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

     InputHandler input;

    private float horizontalInput;
    private float verticalInput;
    private float currentsteerAngle;
    private float currentbrakeForce;
    private bool isBraking;

    [SerializeField] private float motorForce = 3000f;
    [SerializeField] private float brakeForce;
    [SerializeField] private float maxSteerAngle;

    [SerializeField] private WheelCollider frontLeftWheelCollider;
    [SerializeField] private WheelCollider frontRightWheelCollider;
    [SerializeField] private WheelCollider rearLeftWheelCollider;
    [SerializeField] private WheelCollider rearRightWheelCollider;

    [SerializeField] private Transform frontLeftWheelTransform;
    [SerializeField] private Transform frontRightWheelTransform;
    [SerializeField] private Transform rearLeftWheelTransform;
    [SerializeField] private Transform rearRightWheelTransform;

    private void Start()
    {
        input = InputHandler.instance;
    }
    private void GetInput()
    {

        horizontalInput = input.move.x;
        verticalInput = input.move.y;


    }

    private void HandleMotor()
    {
        frontLeftWheelCollider.motorTorque = verticalInput * motorForce * 10 ;
        frontRightWheelCollider.motorTorque = verticalInput * motorForce * 10;
        currentbrakeForce = isBraking ? brakeForce : 50000f;
        if (isBraking)
        {   
            ApplyBraking();
        }
    }

    private void ApplyBraking()
    {

        if (input.isBraking ||  verticalInput == 0)
        {

            frontRightWheelCollider.brakeTorque = currentbrakeForce;
            frontLeftWheelCollider.brakeTorque = currentbrakeForce;
            rearRightWheelCollider.brakeTorque = currentbrakeForce;
            rearLeftWheelCollider.brakeTorque = currentbrakeForce;
        }
        else
        {
            frontRightWheelCollider.brakeTorque = 0f;
            frontLeftWheelCollider.brakeTorque = 0f;
            rearRightWheelCollider.brakeTorque = 0f;
            rearLeftWheelCollider.brakeTorque = 0f;
        }

    }

    private void HandleSteering()
    {
        currentsteerAngle = maxSteerAngle * horizontalInput;
        frontLeftWheelCollider.steerAngle = currentsteerAngle;
        frontRightWheelCollider.steerAngle = currentsteerAngle;
    }

    private void UpdateWheels()
    {
        UpdateSingleWheel(frontLeftWheelCollider, frontLeftWheelTransform);
        UpdateSingleWheel(frontRightWheelCollider, frontRightWheelTransform);
        UpdateSingleWheel(rearLeftWheelCollider, rearLeftWheelTransform);
        UpdateSingleWheel(rearRightWheelCollider, rearRightWheelTransform);

    }

    private void UpdateSingleWheel(WheelCollider WheelCollider, Transform wheelTransform)
    {
        Vector3 pos;
        Quaternion rot;
        WheelCollider.GetWorldPose(out pos, out rot);
        wheelTransform.rotation = rot;
        wheelTransform.position = pos;
    }
    private void FixedUpdate()
    {
        GetInput();
        HandleMotor();
        HandleSteering();
        UpdateWheels();
        ApplyBraking();
    }
}
