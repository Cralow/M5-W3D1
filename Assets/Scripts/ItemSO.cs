using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemSo : ScriptableObject
{
    public string itemName;
    public string description;
    public int id;
    public int healAmount;

    public abstract void Use(GameObject life);
}
