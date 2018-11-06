using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorConfig : MonoBehaviour
{

    Door thisDoor;
    public int unlockID;

    void Awake()
    {
        thisDoor = GetComponentInChildren<Door>();

        unlockID = thisDoor.unlockID;
    }
}
