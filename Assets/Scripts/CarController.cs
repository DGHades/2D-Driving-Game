using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public WheelJoint2D frontWheel;
    public WheelJoint2D rearWheel;
    JointMotor2D front;
    JointMotor2D back;
    public float speedForward,speedBackward;
    public float torqueForward, torqueBackward;
    public bool useFront = true, useRear = true;
    public Rigidbody2D carBody;
    public float carRotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            carBody.AddTorque(carRotationSpeed * Input.GetAxisRaw("Vertical") * 1);


            if (useFront)
            {
                front.motorSpeed = speedForward;
                front.maxMotorTorque = torqueForward;
                frontWheel.motor = front;
            }
            if (useRear)
            {
                back.motorSpeed = speedForward;
                back.maxMotorTorque = torqueForward;
                rearWheel.motor = back;
            } 
        }
        else if (Input.GetAxisRaw("Vertical") > 0)
        {
            carBody.AddTorque(carRotationSpeed * Input.GetAxisRaw("Vertical") * 1);
            if (useFront)
            {
                front.motorSpeed = speedBackward;
                front.maxMotorTorque = torqueBackward;
                frontWheel.motor = front;
            }
            if (useRear)
            {
                back.motorSpeed = speedBackward;
                back.maxMotorTorque = torqueBackward;
                rearWheel.motor = back;
            }
        }
        else
        {
            rearWheel.useMotor = false;
            frontWheel.useMotor = false;
        }
    }
}
