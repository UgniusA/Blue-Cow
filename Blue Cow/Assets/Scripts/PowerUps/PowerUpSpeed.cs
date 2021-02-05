using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpeed : PowerUp {

    [SerializeField] float speedMultiplier = 2f;

    public override void PowerUpStat(PlayerController pc) {
        pc.moveSpeed *= speedMultiplier;
    }

    public override void PowerDownStat(PlayerController pc) {
        pc.moveSpeed /= speedMultiplier;
    }
}
