using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingObjectStats : MonoBehaviour
{
    public double maxHealth;
    private double health;

    void Start()
    {
        health = maxHealth;
    }

    public void Damage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            gameObject.SetActive(false);
        }
        // K 👍
    }
}
