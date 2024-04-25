using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class Selltotal2 : MonoBehaviour
{
    //[SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] Text scoreText;
    public int count = 0;
    public int score2 = 0;
    int tem;

    void Awake()
    {

        score2 = PlayerPrefs.GetInt("Scoretotal", 0); // Default value 1000 if no previous score exists
        UpdateScoreText();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("mini"))
        {
            score2 += 10;
            UpdateScoreText();
            Destroy(other.gameObject);
            count++;
        }
        else if (other.gameObject.layer == LayerMask.NameToLayer("medium"))
        {
            score2 += 20;
            UpdateScoreText();
            Destroy(other.gameObject);
            count++;
        }
        else if (other.gameObject.layer == LayerMask.NameToLayer("big"))
        {
            score2 += 30;

            UpdateScoreText();
            Destroy(other.gameObject);
            count++;
        }
    }

    void UpdateScoreText()
    {
        tem = score2 + Scoretotal.scoreInt;
        scoreText.text = "Score : " + tem.ToString();
    }

    // Save the score before changing scenes
    void OnDestroy()
    {
        PlayerPrefs.SetInt("Scoretotal", score2);
        PlayerPrefs.Save();
    }

    // Method to reset score
    public void ResetScore()
    {
        score2 = 0;
        UpdateScoreText();
    }
}
