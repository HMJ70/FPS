using UnityEngine;

public class Ammo : MonoBehaviour
{
    public static int M9Ammo = 36;
    [SerializeField] GameObject ammoDP;

    void Update()
    {
        ammoDP.GetComponent<TMPro.TMP_Text>().text = "" + M9Ammo;


    }
}
