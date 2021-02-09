using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour {

    [SerializeField] GameObject pickupEffect;

    [Header("Information UI")]
    [SerializeField] string itemName;
    [SerializeField] Sprite itemSprite;
    [SerializeField] [TextArea] string itemInfo;

    [HideInInspector] public Inventory i;

    void Start() {
        i = FindObjectOfType<Inventory>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.GetComponent<PlayerController>()) {
            if (pickupEffect != null) {
                Instantiate(pickupEffect, transform.position, transform.rotation);
            }
            DisplayInformation();
            Pickup();
            Destroy(gameObject);
        }
    }

    public virtual void Pickup() {
        i.UpdateUI();
    }

    void DisplayInformation() {
        i.itemTitle.text = itemName;
        i.itemSprite.sprite = itemSprite;
        i.itemInfo.text = itemInfo;
        i.itemInfoUI.SetActive(true);
        Time.timeScale = 0;
    }
}