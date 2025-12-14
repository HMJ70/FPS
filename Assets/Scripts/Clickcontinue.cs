using UnityEngine;
using UnityEngine.SceneManagement;

public class Clickcontinue : MonoBehaviour
{

    void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            SceneManager.LoadScene("SampleScene");
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
