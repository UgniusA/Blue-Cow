using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpPickUp : Collectable {

    public enum PowerUpType { Speed, Jump, Health, Immortal, All};
    [SerializeField] PowerUpType powerUpType = PowerUpType.Health;

    public override void Pickup() {
        switch (powerUpType) {
            case PowerUpType.Speed:
                i.speedBoost.count++;
                break;

            case PowerUpType.Jump:
                i.jumpBoost.count++;
                break;

            case PowerUpType.Health:
                i.healthBoost.count++;
                break;

            case PowerUpType.Immortal:
                i.immortalBoost.count++;
                break;

            case PowerUpType.All:
                i.superBoost.count++;
                break;
        }
        i.UpdateUI();
    }
}
