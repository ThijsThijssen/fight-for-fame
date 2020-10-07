using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] public float maxHealth = 100f;

    private float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        if ((currentHealth - damage) < 0f)
        {
            currentHealth = 0;
        }
        else
        {
            currentHealth -= damage;
        }

        Debug.Log(name + " current health: " + currentHealth);

        if (currentHealth == 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Debug.Log(name + " died!");
        FindObjectOfType<EnemyManager>().RemoveEnemy(gameObject);
    }
}
