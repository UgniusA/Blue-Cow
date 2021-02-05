using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpJump : PowerUp {

    [SerializeField] float jumpMultiplier = 2f;

    public override void PowerUpStat(PlayerController pc) {
        pc.moveSpeed *= jumpMultiplier;
    }

    public override void PowerDownStat(PlayerController pc) {
        pc.moveSpeed /= jumpMultiplier;
    }
}
