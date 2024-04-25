using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class nextscore : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("upgrade");
    }
}