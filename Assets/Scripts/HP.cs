using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class HP : MonoBehaviour
{
    public GameObject hpdisplay;
    public static int hpvalue;
    public int internalhp;
    void Start()
    {
        hpvalue = 100;
    }
    void Update()
    {
        internalhp = hpvalue;
        hpdisplay.GetComponent<TextMeshProUGUI>().text = "" + hpvalue;
    }
}
