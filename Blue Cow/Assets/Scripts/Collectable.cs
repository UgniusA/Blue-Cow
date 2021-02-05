using UnityEngine;

public class Collectable : MonoBehaviour {

    [SerializeField] GameObject pickupEffect;
    [HideInInspector] public Inventory i;

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

    public virtual void Pickup() {
        i.UpdateUI();
    }
}