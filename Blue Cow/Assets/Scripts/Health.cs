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
            UpdateHealth();
        }
    }

    public IEnumerator DamageOverTime(int damage, float tickTime, float duration) {
        if (duration == 0) {
            while (true) {
                yield return new WaitForSeconds(tickTime);
                Damage(damage);
                duration -= tickTime;
            }
        }
        else {
            while (duration > 0) {
                yield return new WaitForSeconds(tickTime);
                Damage(damage);
                duration -= tickTime;
            }
            yield break;
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
