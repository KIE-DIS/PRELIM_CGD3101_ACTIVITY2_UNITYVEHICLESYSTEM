using UnityEngine;

public class RoadVehicle : MonoBehaviour, ITurnable, IMovable
{
    //RoadVehicle
    public int speed;

    public int turnSpeed;

    //ITurnable
    public virtual void TurnLeft()
    { 
        Debug.Log("Turning left...");
    }

    public virtual void TurnRight()
    {
        Debug.Log("Turning right...");
    }

    //IMovable
    public virtual void GoForward()
    {
        Debug.Log("Going forward...");
    }

    public virtual void Reverse()
    {
        Debug.Log("Going back...");
    }
}
