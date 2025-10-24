using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    public string hittag;
    public bool lookingatplayer = false;
    public GameObject soldier;
    void Update()
    {
        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.forward * 50f, Color.red);

        if (Physics.Raycast(transform.position, transform.forward, out hit, 50f))
        {
            hittag = hit.transform.tag;
        }

        if (hittag == "Player")
        {
            soldier.GetComponent<Animator>().Play("Fire SniperRifle");
            lookingatplayer = true;
        }
        else
        {
            soldier.GetComponent<Animator>().Play("Idle Rifle");
            lookingatplayer = false;
        }
    }

}
