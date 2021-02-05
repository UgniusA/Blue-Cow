using System.Collections;
using UnityEngine;

public class PowerUp : MonoBehaviour {

    public bool active;
    public float duration = 1f;

    public void EnablePowerUp() {
        StartCoroutine(DoPowerUp());
    }

    public IEnumerator DoPowerUp() {
        PlayerStats stats = FindObjectOfType<PlayerStats>();

        PowerUpStat(stats);
        active = true;

        yield return new WaitForSeconds(duration);

        PowerDownStat(stats);
        active = false;
    }

    public virtual void PowerUpStat(PlayerStats stats) {
        //change a stat for power up
    }

    public virtual void PowerDownStat(PlayerStats stats) {
        //reset stat when power up runs out
    }
}