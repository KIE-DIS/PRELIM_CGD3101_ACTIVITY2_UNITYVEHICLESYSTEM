using UnityEngine;

public class Car : RoadVehicle
{
    void Start()
    {
        base.TurnLeft();

        base.TurnRight();

        base.GoForward();

        base.Reverse();
    }
}
