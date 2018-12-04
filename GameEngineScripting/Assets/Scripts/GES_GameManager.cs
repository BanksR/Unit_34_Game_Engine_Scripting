using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GES_GameManager : MonoBehaviour 
{

    private int currentScene;
    private int numScenes;
    private bool inGame = false;


    //This line creates a static version of this class called instance
    //To access this class and its Functions and Variables we would use
    // the . operator - GES_Manager.Instance.StaticTestFunction();
    public static GES_GameManager instance;

    private void Awake()
    {
        StartCoroutine(UIFader.instance.FadeIn());
        //This assigns the variable instance to 'this' instance of the class.
        //We could do additional tests here to make sure there is only ever one instance of this
        //Class in our scene as an additional bug prevention measure
        //DontDestroyOnLoad(this);
        instance = this;
        currentScene = SceneManager.GetActiveScene().buildIndex;
        //Debug.Log(currentScene + SceneManager.GetActiveScene().name.ToString());
    }


    public void ReloadThisLevel()
    {
        
        SceneManager.LoadScene(currentScene);
    }


    // This function can be called from any script to laod the next scene/level
    public void LoadNextLevel()
    {
        StartCoroutine(UIFader.instance.FadeIn());
        currentScene++;
        SceneManager.LoadScene(currentScene % SceneManager.sceneCountInBuildSettings);
        inGame = true;
        //Debug.Log(inGame);
    }

    // This function can be called from any script to load the main menu
    public void LoadMainMenu()
    {
        inGame = false;
        SceneManager.LoadScene("MainMenu");   
    }

    private void Update()
    {

        //This will check every frame to see how many pickup objects are in the scene
        if (PowerUpBlock.PickUpCount == 0 && SceneManager.GetActiveScene().name != "MainMenu")
        {
            LoadNextLevel();
        }


        //Escape the game - back to MainMenu
        if (Input.GetKey(KeyCode.Escape))
        {
            LoadMainMenu();
        }

        if (!inGame && SceneManager.GetActiveScene().name == "MainMenu" && Input.anyKey)
        {
            SceneManager.LoadScene(1);
        }
    }
}
