using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public bool immortal;
    public int health;
    public float moveSpeed;
    public float jumpSpeed;

    PlayerController pc;

    private void Start() {
        pc = GetComponent<PlayerController>();
    }

    public void UpdatePlayerStats() {
        pc.moveSpeed = moveSpeed;
        pc.jumpSpeed = jumpSpeed;
        pc.GetComponent<Health>().health = health;
        pc.GetComponent<Health>().immortal = immortal;
    }
}
