using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{



    public List<Key> keyInventory = new List<Key>();

    public void AddKey(Key newKey)
    {
        keyInventory.Add(newKey);

    }

    public void RemoveKey(Key usedKey)
    {
        keyInventory.Remove(usedKey);

    }
}
