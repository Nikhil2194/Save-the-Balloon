using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverManager : MonoBehaviour
{
   

    private void Awake()
    {
   
    }
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Start");
    }
}
