using System.Collections;
using UnityEngine;

public class Gunshot : MonoBehaviour
{

    [SerializeField] AudioSource gunshot;
    [SerializeField] GameObject M9;
    [SerializeField] bool canshoot = true;
    [SerializeField] AudioSource noammo;
    [SerializeField] GameObject XCross;
    [SerializeField] GameObject Cross;

    public GameObject Mflash;
    public float totarget;

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            if(canshoot == true)
            {
                if(Ammo.M9Ammo == 0)
                {
                    canshoot = false;
                    StartCoroutine(NoAmmo());
                }
                else
                {
                    canshoot = false;
                    StartCoroutine(Shoot());
                }
            }
        }
    }

    IEnumerator Shoot()
    {
        gunshot.Play();
        XCross.SetActive(true);
        Cross.SetActive(false);
        Ammo.M9Ammo -= 1;

        totarget = PlayerCast.targetdistance;
        
        M9.GetComponent<Animator>().Play("M9shoot");

        Mflash.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        Mflash.SetActive(false);

        yield return new WaitForSeconds(0.45f);
        M9.GetComponent<Animator>().Play("New State");
        XCross.SetActive(false);
        Cross.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        canshoot = true;
    }

    IEnumerator NoAmmo()
    {
        noammo.Play();
        yield return new WaitForSeconds(0.6f);
        canshoot = true;
    }
}
