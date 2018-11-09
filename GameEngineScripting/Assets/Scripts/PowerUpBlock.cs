using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBlock : MonoBehaviour 
{

    //public AudioClip pickUpSFX;

    public static int PickUpCount;
    public AudioClip PowerUpSound;

    private void Awake()
    {
        PickUpCount++;

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {

            AudioManager.Instance.PlayMe(PowerUpSound);
            gameObject.SetActive(false);
            PickUpCount--;
            //Debug.Log(pickUpCount);

        }
    }
}
