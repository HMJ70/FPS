using UnityEngine;

public class Doorbutton : MonoBehaviour
{
    public float distance;
    public GameObject actiondisplay;
    public GameObject actiontext;
    public GameObject leftdoor;
    public GameObject rightdoor;

    void Update()
    {
        distance = PlayerCast.targetdistance;
    }

    void OnMouseOver()
    {
        if(distance <= 3)
        {
            actiondisplay.SetActive(true);
            actiontext.SetActive(true);
            if(Input.GetButtonDown("Action"))
            {
                this.GetComponent<BoxCollider>().enabled = false;
                actiondisplay.SetActive(false);
                actiontext.SetActive(false);
                leftdoor.GetComponent<Animator>().Play("leftslide");
                rightdoor.GetComponent<Animator>().Play("rightslide");
            }
        }

    }
    void OnMouseExit()
    {
        actiondisplay.SetActive(false);
        actiontext.SetActive(false);
    }
}
