using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealt = 100;
    public int currentHealth;

    public HealthBar healthBar;


    void Start()
    {
        currentHealth = maxHealt;
        healthBar.SetMaxHealth(maxHealt);
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
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}