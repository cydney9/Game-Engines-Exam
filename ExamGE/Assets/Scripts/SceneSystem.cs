using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneSystem : MonoBehaviour
{
  
    public void startButton() 
    {
        SceneManager.LoadScene("Game");

    }
    public void pauseButton() 
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else 
        {
            Time.timeScale = 1;
        }
    }
}
