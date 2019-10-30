using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour 
{

    //public Dialog NPCPhrases;
    public Canvas dialogCanvas;
    private Dialog NPCPhrases;
    public Vector3 offset = new Vector3(0f, 0f, 0f);


    void Awake()
    {
        //dialogCanvas = GameObject.FindWithTag("Dialog").GetComponent<Canvas>();
        //NPCPhrases = dialogCanvas.GetComponentInChildren<Dialog>();

        //dialogCanvas.transform.SetParent(this.transform, false);
        //dialogCanvas.transform.localPosition += offset;


    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            //Debug.Log("Bump!_");
            NPCPhrases.DisplayText();
        }
    }
}
