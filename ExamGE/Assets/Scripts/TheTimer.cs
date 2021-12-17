using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TheTimer : MonoBehaviour
{
    public Text theTimer;
    private int birdCount;
    public int score;
   
    private float x; //The amount of time


    // Start is called before the first frame update
    void Start()
    {
        x = 50;
        theTimer.text = "";
        birdCount = GameObject.FindGameObjectsWithTag("Bird").Length;
    }


    // Update is called once per frame
    void Update()
    {
        if (x > 0)
        {
            x -= Time.deltaTime;
            theTimer.text = "Timer: " + x.ToString();
        }
        else if (birdCount == 0 & score >= 1000) 
        {
            SceneManager.LoadScene("Win");
        }
        else
        {

            SceneManager.LoadScene("GameOver");
        }
    }
}
