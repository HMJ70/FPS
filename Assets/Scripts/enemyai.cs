using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyai : MonoBehaviour
{
    public string hittag;
    public bool lookingatplayer = false;
    public GameObject soldier;
    public AudioSource firesound;
    public bool isfiring = false;
    public float firerate = 0.5f;
    void Update()
    {
        RaycastHit hit; 
        Debug.DrawRay(transform.position, transform.forward * 50f, Color.red);

        if (Physics.Raycast(transform.position, transform.forward, out hit, 50f))
        {
            hittag = hit.transform.tag;
        }
        if (hittag == "Player" && isfiring == false)
        {
            StartCoroutine(EnemyFire());
        }
        if(hittag != "Player")
        {
            soldier.GetComponent<Animator>().Play("Idle Rifle");
            lookingatplayer = false;
        }
    }

    IEnumerator EnemyFire()
    {
        isfiring = true;
        soldier.GetComponent<Animator>().Play("Fire SniperRifle", -1,0);
        soldier.GetComponent<Animator>().Play("Fire SniperRifle");
        firesound.Play();
        lookingatplayer = true;
        HP.hpvalue -= 5;
        yield return new WaitForSeconds(firerate);
        isfiring = false;
    }
}
