using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shooting : MonoBehaviour
{

    private int score = 0;
    public Text theScore;
    private int lives = 5;
    public Text theLives;
    private Ray ray;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        theScore.text = "Score: " + score;
        theLives.text = "Lives: " + lives;
    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetMouseButtonDown(0)) 
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
        }
        if (Physics.Raycast(ray, out hit)) 
        {
            if (hit.collider.tag == "Bird")
            {
                Destroy(hit.collider.gameObject);
                lives -= 1;
                score += 500;
                theScore.text = "Score: " + score;
                theLives.text = "Lives: " + lives;
            }

        }
        */
    }
}
