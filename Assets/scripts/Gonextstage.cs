using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gonextstage : MonoBehaviour
{
    public string scenename;
    public Sell sell;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Score.scoreInt += sell.score;
            SceneManager.LoadScene(scenename);
        }
    }
}
