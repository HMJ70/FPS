using UnityEngine;
using TMPro; 
using UnityEngine.UI; 

public class score : MonoBehaviour
{
    public TMP_Text tmpScoreText;

    public static int currentScore = 0;

    void Start()
    {
        currentScore = 0;
        UpdateScoreUI();
    }

    void Update()
    {
     
        UpdateScoreUI();
    }

    public static void AddScore(int amount)
    {
        currentScore += amount;
    }

    void UpdateScoreUI()
    {
        if (tmpScoreText != null)
            tmpScoreText.text = "" + currentScore;

    }
}
