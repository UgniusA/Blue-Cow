using System.Collections;
using UnityEngine;

public class PowerUp : MonoBehaviour {

    [SerializeField] GameObject pickupEffect;
    [SerializeField] float duration;

    void OnTriggerEnter2D(Collider2D other) {
        if (other.GetComponent<PlayerController>()) {
            StartCoroutine(Pickup(other));
        }
    }

    public IEnumerator Pickup(Collider2D player) {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        PlayerController pc = player.GetComponent<PlayerController>();

        PowerUpStat(pc);

        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;

        yield return new WaitForSeconds(duration);

        PowerDownStat(pc);

        Destroy(gameObject);
    }

    public virtual void PowerUpStat(PlayerController pc) {
        //change a stat for power up
    }

    public virtual void PowerDownStat(PlayerController pc) {
        //reset stat when power up runs out
    }
}