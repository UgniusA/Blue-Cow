using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour, IDamageable {

    public bool immortal;
    public int health = 100;
    public int maxHealth = 100;

    public void Damage(int damage) {
        if (!immortal) {
            health -= damage;
        }
    }

    public void UpdateHealth() {
        if (health <= 0) {
            DestroyObject();
        }
    }

    public void DestroyObject() {
        health = 0;
        Destroy(gameObject);
    }
}
