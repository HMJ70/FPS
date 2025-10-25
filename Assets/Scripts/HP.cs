using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
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
        if(hpvalue <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        internalhp = hpvalue;
        hpdisplay.GetComponent<TextMeshProUGUI>().text = "" + hpvalue;
    }
}
