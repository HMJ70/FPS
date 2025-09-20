using UnityEngine;

public class EnemyLook : MonoBehaviour
{
    public Transform player;


    void Update()
    {
        transform.LookAt(player);
    }
}
