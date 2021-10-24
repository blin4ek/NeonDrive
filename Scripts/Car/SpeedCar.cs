using UnityEngine;

public class SpeedCar : MonoBehaviour
{
    [SerializeField] private WheelJoint2D rearWheel;
    [SerializeField] private WheelJoint2D frontWheel;

    JointMotor2D motor = new JointMotor2D();

    private float ratioIncreaseSpeed = 50;

    private void Start()
    {
        motor = rearWheel.motor;
        motor.motorSpeed = -1500; 
        rearWheel.motor = motor;
        frontWheel.motor = motor;
        CarBreakingBarrier.RegHandler(IncreaseSpeed);
    }

    private void IncreaseSpeed()
    {
        motor.motorSpeed -= ratioIncreaseSpeed;
        rearWheel.motor = motor;
        frontWheel.motor = motor;
    }
}