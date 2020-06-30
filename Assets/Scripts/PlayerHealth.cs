using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int maxMana = 100;
    public int currentHealth;
    public int currentMana;
    public healthBAR healthBar;
    public manaBAR manaBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        currentMana = maxMana;
        manaBar.SetMaxMana(maxMana);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDMG(20);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
           UseMagic(20);
        }
    }
    public void TakeDMG(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
    public void UseMagic(int mana)
    {
        currentMana -= mana;
        manaBar.SetMana(currentMana);
    }
}