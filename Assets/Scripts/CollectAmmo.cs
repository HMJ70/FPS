using UnityEngine;

public class CollectAmmo : MonoBehaviour
{
    [SerializeField] AudioSource collectammo;

    

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        collectammo.Play();
        Ammo.M9Ammo += 12;

        Destroy(gameObject);
    }
}
