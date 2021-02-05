using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpHealth : PowerUp {

    [SerializeField] int healthBonus = 50;

    public override void PowerUpStat(PlayerStats stats) {
        stats.health += healthBonus;
        stats.UpdatePlayerStats();
    }

    public override void PowerDownStat(PlayerStats stats) {
        stats.health -= healthBonus;
        stats.UpdatePlayerStats();
    }
}
