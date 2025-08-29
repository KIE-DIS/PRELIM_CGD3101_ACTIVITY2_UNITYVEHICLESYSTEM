using UnityEngine;

public class RailVehicle : MonoBehaviour, IMovable
{
    //RailVehicle
    public int speed;

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
