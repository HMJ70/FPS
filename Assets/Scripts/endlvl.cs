using UnityEngine;
using UnityEngine.SceneManagement;

public class endlvl : MonoBehaviour
{
    public string playerTag = "Player";

    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (triggered) return;

        if (other.CompareTag(playerTag))
        {
            triggered = true;
            SceneManager.LoadScene("Victory");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
