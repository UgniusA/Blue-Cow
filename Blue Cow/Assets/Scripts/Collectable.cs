using UnityEngine;

public class Collectable : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other) {
        if (other.GetComponent<PlayerController>()) {
            Pickup();
        }
    }

    public virtual void Pickup() {

    }
}