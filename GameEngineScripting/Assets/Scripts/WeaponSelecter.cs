using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelecter : MonoBehaviour 
{

    public Weapon ak74;
    public Weapon mp5;
    public Weapon rpg;
    public Weapon shotgun;

    private Weapon currentlySelectedWeapon;

	// Use this for initialization
	void Start () 
    {
        currentlySelectedWeapon = ak74;
	}
	
	// Update is called once per frame
	void Update () 
    {


        WeaponSelection();


        // Shoot
        if(Input.GetMouseButtonDown(0))
        {
            currentlySelectedWeapon.Shoot();
        }
        // Reload
        if (Input.GetKeyDown(KeyCode.R))
        {
            currentlySelectedWeapon.Reload();
        }
	}



    void WeaponSelection()
    {
		if (Input.GetKey(KeyCode.Alpha1))
		{
			currentlySelectedWeapon = ak74;
		}
		if (Input.GetKey(KeyCode.Alpha2))
		{
			currentlySelectedWeapon = mp5;
		}
		if (Input.GetKey(KeyCode.Alpha3))
		{
			currentlySelectedWeapon = rpg;
		}
    }
}
