using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSuper : PowerUp {

    [SerializeField] int healthBonus = 50;
    [SerializeField] float speedMultiplier = 2f;
    [SerializeField] float jumpMultiplier = 3f;

    public override void PowerUpStat(PlayerStats stats) {
        stats.health += healthBonus;
        stats.moveSpeed *= speedMultiplier;
        stats.jumpSpeed *= jumpMultiplier;
        stats.immortal = true;
        stats.UpdatePlayerStats();
    }

    public override void PowerDownStat(PlayerStats stats) {
        stats.health -= healthBonus;
        stats.moveSpeed /= speedMultiplier;
        stats.jumpSpeed /= jumpMultiplier;
        stats.immortal = false;
        stats.UpdatePlayerStats();
    }
}
