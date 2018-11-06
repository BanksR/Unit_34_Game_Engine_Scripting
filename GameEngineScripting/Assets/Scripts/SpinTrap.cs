using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpinTrap : MonoBehaviour 
{

    public float spinRate = 90f;
    public AudioClip deathSound;



    void Awake()
    {
        
    }

	
	
	// Update is called once per frame
	void Update () 
    {
        transform.Rotate(0f, 0f,spinRate*Time.deltaTime);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            ParticleManager.Instance.KillPlayer(collision.transform);
            
            //AudioManager.Instance.PlayerDeath(deathSound);

            

            GES_GameManager.instance.ReloadThisLevel();
            collision.gameObject.SetActive(false);

            //Start respawn coroutine on the GameManager
        }
    }
}
