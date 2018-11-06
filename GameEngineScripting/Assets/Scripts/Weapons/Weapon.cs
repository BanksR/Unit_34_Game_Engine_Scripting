using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public string weaponName;
    public int ammo;
    public int maxAmmo;


    public void Shoot()
    {
        if(ammo > 0)
        {
			ammo--;
			Debug.Log(weaponName + " shoots: " + ammo + " / " + maxAmmo); 
        }

        else if (ammo <= 0)
        {
            Debug.Log(weaponName + " is out of ammo! " + " 0 /" + maxAmmo);
        }


    }

    public void Reload()
    {
        ammo = maxAmmo;
    }
}
