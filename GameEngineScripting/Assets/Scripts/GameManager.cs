using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour 
{

    public static GameManager Instance { get; private set; }


    //Events
    public delegate void OnPlayerDeath();
    public static event OnPlayerDeath PlayerDied;

    //Init the time component of the level
    public Slider timeSlider;
    public Image timeOut;
    public Image youWin;
    public float levelTime = 10f;


    //Global player control - when false player input have no action
    public bool canControl = true;

    //Search for powerup blocks in the level
    private GameObject[] powerBlocks;
    public int numOfBlocks;

    private float currentTime;
    private bool goTime = true;

    //SceneManagement stuff
    private int currentScene = 0;

	// Use this for initialization
	void Awake () 
    {
        Instance = this;
        currentTime = levelTime;
        timeSlider.maxValue = levelTime;
        timeSlider.value = levelTime;
        timeOut.enabled = false;

        powerBlocks = GameObject.FindGameObjectsWithTag("PowerUpBlock");
        numOfBlocks = powerBlocks.Length;

        currentScene = 0;
        	
	}



    void Update()
    {
        
        CountDownTimer();
    }






    public void CountDownTimer()
    {
        if(currentTime > Mathf.Epsilon && numOfBlocks != 0 && goTime)
        {
			currentTime -= Time.deltaTime;
			timeSlider.value = currentTime;

        }
        else if (numOfBlocks > 0)
        {
            canControl = false;
            StartCoroutine("TimeOver");
        }

        
    }



    public IEnumerator TimeOver()
    {
        timeOut.enabled = true;

        yield return new WaitForSeconds(3);
        //Debug.Log(currentScene.name.ToString());
        SceneManager.LoadScene(currentScene);
        //Reload same level...

        yield return null;
        
    }



    public IEnumerator YouWin()
    {
        goTime = false;
        youWin.enabled = true;

        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(currentScene + 1 % SceneManager.sceneCount);
        //start next level
    }



    public IEnumerator StartLevel(int level)
    {
       //Cross fade into new level
        yield return null;
    }

    public IEnumerator GameOver()
    {
        //Fade out, return to MainMenuScene

        yield return null;
    }

    public void MainMenuScene()
    {
        //Load the UI Main menu, can be called on Game Over or Escape key pressed
    }



    public void BlockCounter(int minusBlock)
    {
        //This function counts the number of power up blocks collected, when 0 the 'YouWin' function is called
        numOfBlocks -= minusBlock;

        if(numOfBlocks == 0)
        {
            canControl = false;
            StartCoroutine("YouWin");
        }
    }
	
}
