using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayLives : MonoBehaviour 
{

    GameManager gm;

    Image[] livesImg;
    int currentNumBlocks;

    // Use this for initialization
	void Start () 
    {
        gm = GameManager.Instance;
        currentNumBlocks = gm.numOfBlocks;
        livesImg = GetComponentsInChildren<Image>();
        InitLives();




        for (int i = 0; i < gm.numOfBlocks; i++)
        {
            livesImg[i].enabled = true;

        }
    }

    // Update is called once per frame
    void Update () 
    {
        if(gm.numOfBlocks != currentNumBlocks)
        {
            UpdateLives();
        }
	}

    void InitLives()
    {
        foreach (Image item in livesImg)
        {
            item.enabled = false;
        }
    }

    void UpdateLives()
    {
        livesImg[gm.numOfBlocks].enabled = false;

    }
}
