using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : PickUp 
{

    public int keyID;
    public string keyName = "";


    private PlayerInventory inv;


    void Awake()
    {
        inv = GameObject.FindWithTag("Player").GetComponent<PlayerInventory>();

    }

	
    public void OnTriggerEnter2D(Collider2D other)
    {
        ParticleManager.Instance.PickUp(transform);
        inv.AddKey(this);

        base.OnTriggerEnter2D(other);
    }


}
