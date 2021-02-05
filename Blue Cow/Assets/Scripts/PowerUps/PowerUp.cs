using System.Collections;
using UnityEngine;

public class PowerUp : MonoBehaviour {

    [SerializeField] float duration = 1f;

    public IEnumerator Pickup() {

        PlayerStats stats = FindObjectOfType<PlayerStats>();

        PowerUpStat(stats);

        yield return new WaitForSeconds(duration);

        PowerDownStat(stats);
    }

    public virtual void PowerUpStat(PlayerStats stats) {
        //change a stat for power up
    }

    public virtual void PowerDownStat(PlayerStats stats) {
        //reset stat when power up runs out
    }
}