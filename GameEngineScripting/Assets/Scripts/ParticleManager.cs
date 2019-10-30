using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{

    public static ParticleManager Instance { get; private set; }


    public ParticleSystem powerUpBlockDestroy;
    public ParticleSystem powerUp;
    public ParticleSystem playerDeath;
    public ParticleSystem pickUpParts;
    public ParticleSystem rubble;


    void Awake()
    {
        Instance = this;
    }


    public void PowerUpParticle(Transform spawnPos)
    {
        if (powerUp != null)
        {
            powerUpBlockDestroy.transform.position = spawnPos.position;
            powerUpBlockDestroy.Play();
        }

             
    }

    public void PlayerPowerUp(Transform spawnPos)
    {
        powerUp.transform.position = spawnPos.position;
        powerUp.Play();
    }

    public void KillPlayer(Transform spawnPos)
    {
        Debug.Log("KillPlayerCAlled");
        playerDeath.Stop();
        playerDeath.transform.position = spawnPos.position;
        playerDeath.Play();
    }

    public void PickUp(Transform spawnPos)
    {
        pickUpParts.Stop();
        pickUpParts.transform.position = spawnPos.position;
        Debug.Log("About to play pickUPParts...");
        pickUpParts.Play(true);
		Debug.Log("I have played PickupParts...");
		
    }
    public void Rubble()
    {
        rubble.Play();
    }
}
