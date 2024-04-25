using UnityEngine;

public class ResetPlayerPrefs : MonoBehaviour
{
    public void ResetPrefs()
    {
        // Reset PlayerPrefs for score and speed
        PlayerPrefs.DeleteKey("Score");
        PlayerPrefs.DeleteKey("Speed");
    }
}
