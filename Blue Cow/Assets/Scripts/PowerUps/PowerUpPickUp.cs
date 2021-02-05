using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpPickUp : Collectable {

    [SerializeField] GameObject powerUp;

    public override void Pickup() {
        if (powerUp.GetComponent<PowerUpSpeed>()) {
            if (i.speedBoost.powerUpControl == null) {
                powerUp.transform.parent = i.transform;
                i.speedBoost.powerUpControl = powerUp.GetComponent<PowerUpSpeed>();
            }
            i.speedBoost.count++;
        }
        if (powerUp.GetComponent<PowerUpJump>()) {
            if (i.jumpBoost.powerUpControl == null) {
                powerUp.transform.parent = i.transform;
                i.jumpBoost.powerUpControl = powerUp.GetComponent<PowerUpJump>();
            }
            i.jumpBoost.count++;
        }
        if (powerUp.GetComponent<PowerUpHealth>()) {
            if (i.healthBoost.powerUpControl == null) {
            powerUp.transform.parent = i.transform;
                i.healthBoost.powerUpControl = powerUp.GetComponent<PowerUpHealth>();
            }
            i.healthBoost.count++;
        }
        if (powerUp.GetComponent<PowerUpImmortal>()) {
            if (i.immortalBoost.powerUpControl == null) {
                powerUp.transform.parent = i.transform;
                i.immortalBoost.powerUpControl = powerUp.GetComponent<PowerUpImmortal>();
            }
            i.immortalBoost.count++;
        }
        if (powerUp.GetComponent<PowerUpSuper>()) {
            if (i.superBoost.powerUpControl == null) {
                powerUp.transform.parent = i.transform;
                i.superBoost.powerUpControl = powerUp.GetComponent<PowerUpSuper>();
            }
            i.superBoost.count++;
        }
        i.UpdateUI();
    }
}
