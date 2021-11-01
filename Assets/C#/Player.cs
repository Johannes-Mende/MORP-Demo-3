using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

public int maxHealth;
public int currentHealth;
public Statusbar healthBar;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
    }
    void TakeDamage(int damage)
    {
        currentHealth-= damage;
        healthBar.SetHealth(currentHealth);
    }
}
