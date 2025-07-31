using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Inventory")]
public class HealthPotionController : ItemSo
{
    public override void Use(GameObject life)
    {
        life.GetComponent<LifeController>().Heal(healAmount);
    }
}
