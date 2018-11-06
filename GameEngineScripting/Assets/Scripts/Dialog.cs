using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    Text text;

    List<string> phrases;
    bool canGetNewPhrase;

	// Use this for initialization
	void Start () 
    {
        canGetNewPhrase = true;
        text = GetComponent<Text>();
        text.color = Color.clear;
        phrases = new List<string>();
        GetPhrase();
		
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    public void GetPhrase()
    {
        phrases.Add("Hello");
        phrases.Add("You should leave");
        phrases.Add("Go away");
        phrases.Add("Could you please stop doing that");
        phrases.Add("Did you bring a ladder...");
        phrases.Add("Honestly, I didn't think i'd ever see anyone else down here");
        phrases.Add("Why don't you just climb out?");
        phrases.Add("I like your t-shirt");
        phrases.Add("I've lost all hope");
        phrases.Add("I'm not stuck here with you - you're stuck here with me");
        phrases.Add("I like it here");
        phrases.Add("I only wanted to be left alone...");
        phrases.Add("I...I...just...please leave me alone");
        phrases.Add("All that jumping - you'll tire yourself out");
        phrases.Add("Do you have any other skills?");
        phrases.Add("What's that rumbling?");
        phrases.Add("Please don't press s again");
       
    }

    public void DisplayText()
    {
        if(canGetNewPhrase)
        {
            //Debug.Log("Triggered");
            string phraseToDisplay = phrases[Random.Range(0, phrases.Count)];
			StartCoroutine(DisplayText(phraseToDisplay));  
        }

    }

    IEnumerator DisplayText(string textToDisplay)
    {
        canGetNewPhrase = false;
        text.text = textToDisplay;
        text.color = Color.white;

        yield return new WaitForSeconds(5f);

        text.color = Color.clear;
        canGetNewPhrase = true;

        yield return null;


        
    }
}
