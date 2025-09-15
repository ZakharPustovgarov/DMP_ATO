using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public event Action OnDeath;

    [SerializeField]
    private int maxHealth = 100;

    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0) OnDeath?.Invoke();
    }
}
