using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpImmortal : PowerUp {

    public override void PowerUpStat(PlayerStats stats) {
        stats.immortal = true;
        stats.UpdatePlayerStats();
    }

    public override void PowerDownStat(PlayerStats stats) {
        stats.immortal = false;
        stats.UpdatePlayerStats();
    }
}
