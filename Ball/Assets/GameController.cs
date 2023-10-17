using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int pickupCount = 0;
    public int score = 0;
    public int hit = 0;
    public int hit1 = 0;
    public Text scoreText;
    public Text pickText;
    public static GameController instance;
    public void Awake()
    {
        if (instance == null) 
        {
            instance = this;
        }
        else 
        {
            Destroy(this);
        }
    }
    private void Update()
    {	
	if(hit == 0 && hit1 == 0)
	{
        	if (pickupCount == 0)
		{
            		scoreText.text = "YOU WIN!!";
	    		pickText.text = "";
		}
        	else
		{
	    		pickText.text = "Pick Up's Left: " + pickupCount;	
            		scoreText.text = "Score: " + score;
		}
	}
	else
	{
		scoreText.text = "YOU LOSE!!";
		pickText.text = "";
	}
	if(Input.GetKeyUp(KeyCode.Q))
        {
            	Application.Quit();
        }
	if(Input.GetKeyDown(KeyCode.R))
	{
             	Scene scene = SceneManager.GetActiveScene(); 
		SceneManager.LoadScene("SampleScene");
        }
    }
}
