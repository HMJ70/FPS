using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heal : MonoBehaviour
{

    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        if (HP.hpvalue >= 91)
        {
            HP.hpvalue = 100;
        }
        else
        {
            HP.hpvalue += 10;
        }
        collectSound.Play();
        GetComponent<BoxCollider>().enabled = false;
        this.gameObject.SetActive(false);
    }

}