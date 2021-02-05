using UnityEngine;

public class Collectable : MonoBehaviour {

    [SerializeField] GameObject pickupEffect;
    Inventory i;

    void Start() {
        i = FindObjectOfType<Inventory>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.GetComponent<PlayerController>()) {
            if (pickupEffect != null) {
                Instantiate(pickupEffect, transform.position, transform.rotation);
            }
            Pickup();
            Destroy(gameObject);
        }
    }

    public void Pickup() {
        if (GetComponent<PowerUpSpeed>()) {
            i.speedBoost.count++;
        }
        if (GetComponent<PowerUpJump>()) {
            i.jumpBoost.count++;
        }/*
        if (GetComponent<PowerUpHealth>()) {
            i.healthBoost.count++;
        }
        if (GetComponent<PowerUpImmortal>()) {
            i.immortalBoost.count++;
        }
        if (GetComponent<PowerUpSuper>()) {
            i.superBoost.count++;
        }*/
        i.UpdateUI();
    }
}