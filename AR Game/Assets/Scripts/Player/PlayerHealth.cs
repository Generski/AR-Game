using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private Vector3 startpos = Vector3.zero;

    [SerializeField] private int maxHealth = 1;
    private int health;

    private void Start()
    {
        transform.position = startpos;

        health = maxHealth;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Water")
        {
            TakeDamage(1);
        }
    }

    private void TakeDamage(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        health = maxHealth;
        transform.position = startpos;
    }
}
