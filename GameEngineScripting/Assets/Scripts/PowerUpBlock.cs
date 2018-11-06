using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBlock : MonoBehaviour 
{

    //public AudioClip pickUpSFX;

    public static int pickUpCount;
    public AudioClip powerUpSound;

    private void Awake()
    {
        pickUpCount++;

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {

            AudioManager.Instance.PlayMe(powerUpSound);
            gameObject.SetActive(false);
            pickUpCount--;
            //Debug.Log(pickUpCount);

        }
    }
}
