using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("SampleScene");
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    public void quit()
    {
        Application.Quit();
    }

    public void tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    
}
