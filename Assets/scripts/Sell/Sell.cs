using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Sell : MonoBehaviour
{
    //[SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] Text scoreText;
    public int count = 0;
    public int score = 0;
    int tem;

    void Awake()
    {
        score = PlayerPrefs.GetInt("Score", 0); // Default value 1000 if no previous score exists
        UpdateScoreText();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("mini"))
        {
            score += 10;
            UpdateScoreText();
            Destroy(other.gameObject);
            count++;
        }
        else if (other.gameObject.layer == LayerMask.NameToLayer("medium"))
        {
            score += 20;
            UpdateScoreText();
            Destroy(other.gameObject);
            count++;
        }
        else if (other.gameObject.layer == LayerMask.NameToLayer("big"))
        {
            score += 30;
            UpdateScoreText();
            Destroy(other.gameObject);
            count++;
        }
    }

    void UpdateScoreText()
    {
        tem = score + Score.scoreInt;
        scoreText.text = "Score : " + tem.ToString();
    }

    // Save the score before changing scenes
    void OnDestroy()
    {
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.Save();
    }

    // Method to reset score
    public void ResetScore()
    {
        score = 0;
        UpdateScoreText();
    }
}
