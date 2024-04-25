using UnityEngine;
using UnityEngine.UI;

public class UpgradeSpeedButton1 : MonoBehaviour
{
    public WaterBoat waterBoat; // prefab waterboat
    public Text scoreText; // คะแนนของเราที่โชว์
    public Text scoreToRemoveText; // ไว้ใช้กับ ราคา ที่ต้องการโชว์
    public Button upgradeButton; // button กดซื้อ

    private int upgradeRound = 0;

    void Start()
    {
       
        int score = PlayerPrefs.GetInt("Score", 0);
        int scoreToRemove = PlayerPrefs.GetInt("ScoreToRemove", 0);

       
        scoreText.text = "Score: " + score.ToString();
        scoreToRemoveText.text = "price : " + scoreToRemove.ToString();

       
        if (score <= scoreToRemove)
        {
            upgradeButton.interactable = false;
        }
    }

    
    void UpdateScore(int newScore, int newScoreToRemove)
    {
        
        scoreText.text = "Score: " + newScore.ToString();
        scoreToRemoveText.text = "price : " + newScoreToRemove.ToString();

       
        if (newScore <= newScoreToRemove)
        {
            upgradeButton.interactable = false;
        }
        else
        {
            upgradeButton.interactable = true;
        }
    }

    
    void SaveScore(int score, int scoreToRemove)
    {
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.SetInt("ScoreToRemove", scoreToRemove);
        PlayerPrefs.Save();
    }

    public void UpgradeSpeed()
    {
       
        int score = PlayerPrefs.GetInt("Score", 0);
        int scoreToRemove = PlayerPrefs.GetInt("ScoreToRemove", 0);

        
        int newScore = score - scoreToRemove;
        int newScoreToRemove = (scoreToRemove + 40); // +40 คือราคาที่จะเพิ่มขึ้นเรื่อยๆ

        
        SaveScore(newScore, newScoreToRemove);

        UpdateScore(newScore, newScoreToRemove);

        // การปรับmaxspeed
        waterBoat.MaxSpeed += 2f;
        // Save ไม่ได้T_T
        PlayerPrefs.SetFloat("Speed", waterBoat.MaxSpeed);

        // Increment upgradeRound for the next round
        upgradeRound++;
    }

    // Method to be called externally to deduct score
    public void DeductScore(int amount)
    {
        int score = PlayerPrefs.GetInt("Score", 0);
        score -= amount;
        SaveScore(score, PlayerPrefs.GetInt("ScoreToRemove", 0));
        UpdateScore(score, PlayerPrefs.GetInt("ScoreToRemove", 0));
    }
}
