using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Weapon 
{

	// Use this for initialization
	void Awake () 
    {
        weaponName = "Shotgun";
        ammo = 15;
        maxAmmo = 15;
	}
	
	
}
