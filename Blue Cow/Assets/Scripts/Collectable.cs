using UnityEngine;

public class Collectable : MonoBehaviour {
    public JumpPowerUp jumpPowerUp = null;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            //collision.GetComponent<PlayerController>().ApplyPowerUp(jumpPowerUp);
            Destroy(gameObject);
        }
    }
}