using System.Collections;
using UnityEngine;

public class Gunshot : MonoBehaviour
{

    [SerializeField] AudioSource gunshot;
    [SerializeField] GameObject M9;
    [SerializeField] bool canshoot = true;

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            if(canshoot == true)
            {
                canshoot = false;
                StartCoroutine(Shoot());
            }
        }
    }

    IEnumerator Shoot()
    {
        gunshot.Play();
        M9.GetComponent<Animator>().Play("M9shoot");
        yield return new WaitForSeconds(0.5f);
        M9.GetComponent<Animator>().Play("New State");
        yield return new WaitForSeconds(0.1f);
        canshoot = true;
    }
}
