using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slow : MonoBehaviour {

    public float slowMultiplier;

    void OnCollisionEnter2D(Collision2D collision) {
        PlayerStats ps = collision.gameObject.GetComponent<PlayerStats>();
        if (ps != null) {
            ps.moveSpeed *= slowMultiplier;
            ps.UpdatePlayerStats();
        }
    }

    void OnCollisionExit2D(Collision2D collision) {
        PlayerStats ps = collision.gameObject.GetComponent<PlayerStats>();
        if (ps != null) {
            ps.moveSpeed /= slowMultiplier;
            ps.UpdatePlayerStats();
        }
    }
}
