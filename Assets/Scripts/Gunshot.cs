using UnityEngine;

public class Gunshot : MonoBehaviour
{

    [SerializeField] AudioSource gunshot;

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            gunshot.Play();
        }
    }
}
