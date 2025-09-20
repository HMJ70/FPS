using UnityEngine;

public class PlayerCast : MonoBehaviour
{
    public static float targetdistance;
    public float totarget;
    

    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit))
        {
            totarget = hit.distance;
            targetdistance = hit.distance;
        }

    }
}
