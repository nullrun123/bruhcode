using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class Sell2 : MonoBehaviour
{
    //[SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] Text scoreText;
    public int count = 0;
    public int score1 = 0;
    int tem;

    void Awake()
    {
        
        score1 = PlayerPrefs.GetInt("Score1", 0); // Default value 1000 if no previous score exists
        UpdateScoreText();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("mini"))
        {
            score1 += 10;
            UpdateScoreText();
            Destroy(other.gameObject);
            count++;
        }
        else if (other.gameObject.layer == LayerMask.NameToLayer("medium"))
        {
            score1 += 20;
            UpdateScoreText();
            Destroy(other.gameObject);
            count++;
        }
        else if (other.gameObject.layer == LayerMask.NameToLayer("big"))
        {
            score1 += 30;
            
            UpdateScoreText();
            Destroy(other.gameObject);
            count++;
        }
    }

    void UpdateScoreText()
    {
        tem = score1 + Score1.scoreInt;
        scoreText.text = "Score : " + tem.ToString();
    }

    // Save the score before changing scenes
    void OnDestroy()
    {
        PlayerPrefs.SetInt("Score1", score1);
        PlayerPrefs.Save();
    }

    // Method to reset score
    public void ResetScore()
    {
        score1 = 0;
        UpdateScoreText();
    }
}
