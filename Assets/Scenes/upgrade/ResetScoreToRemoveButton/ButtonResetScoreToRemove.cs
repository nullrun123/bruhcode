using UnityEngine;
using UnityEngine.UI;

public class ButtonResetScoreToRemove : MonoBehaviour
{
    //public Text scoreToRemoveText; // Reference to the UI text displaying the score to remove

    void Start()
    {
        // Load scoreToRemove from PlayerPrefs
        int scoreToRemove = PlayerPrefs.GetInt("ScoreToRemove", 0);

        // Display scoreToRemove
        //scoreToRemoveText.text = "price : " + scoreToRemove.ToString();
    }

    public void ResetScoreToRemove()
    {
        // Reset scoreToRemove to 0
        PlayerPrefs.SetInt("ScoreToRemove", 40);
        PlayerPrefs.Save();

        // Update displayed scoreToRemove
       // scoreToRemoveText.text = "price : 0";
    }
}
