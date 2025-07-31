using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PickUpManager : MonoBehaviour
{
    public ItemSo item;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerInventory>().AddItem(item);
            Destroy(this.gameObject);
        }
        
    }

}
