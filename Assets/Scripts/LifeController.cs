using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeController : MonoBehaviour
{
    [SerializeField] int hp;
    public Text healthUI;

    private void Start()
    {
        hp = 0;
    }
    public void Heal(int amount)
    {
         hp += amount;
    }
    private void Update()
    {
        healthUI.text = hp.ToString();
    }
}
