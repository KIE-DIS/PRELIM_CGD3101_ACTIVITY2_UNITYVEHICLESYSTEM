using UnityEngine;

public class Train : RailVehicle
{
    void Start()
    {
        base.GoForward();

        base.Reverse();
    }
}
