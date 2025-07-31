using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PlayerInventory : MonoBehaviour
{
    [SerializeField] private List<ItemSo> inventory = new List<ItemSo>();
    private void Update()
    {
        for (int i = 0; i < 9; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                if (i < inventory.Count && inventory[i] != null)
                {
                    inventory[i].Use(gameObject);
                    inventory.RemoveAt(i);
                }
                break;
            }
        }
    }
    public void AddItem(ItemSo item)
    {
        inventory.Add(item);
        inventory.OrderBy(item => item.id).ToList();
    }
}
