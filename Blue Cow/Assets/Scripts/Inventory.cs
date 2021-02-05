using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class Boosts {
    public int count;
    public GameObject ItemUI;
    public Text countUI;
}

public class Inventory : MonoBehaviour {

    public Boosts speedBoost;
    public Boosts jumpBoost;
    public Boosts healthBoost;
    public Boosts immortalBoost;
    public Boosts superBoost;

    public void UpdateUI() {
        speedBoost.ItemUI.SetActive(speedBoost.count > 0);
        speedBoost.countUI.text = "" + speedBoost.count;

        jumpBoost.ItemUI.SetActive(jumpBoost.count > 0);
        jumpBoost.countUI.text = "" + jumpBoost.count;

        healthBoost.ItemUI.SetActive(healthBoost.count > 0);
        healthBoost.countUI.text = "" + healthBoost.count;

        immortalBoost.ItemUI.SetActive(immortalBoost.count > 0);
        immortalBoost.countUI.text = "" + immortalBoost.count;

        superBoost.ItemUI.SetActive(superBoost.count > 0);
        superBoost.countUI.text = "" + superBoost.count;
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {

        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) {

        }
        if (Input.GetKeyDown(KeyCode.Alpha3)) {

        }
        if (Input.GetKeyDown(KeyCode.Alpha4)) {

        }
        if (Input.GetKeyDown(KeyCode.Alpha5)) {

        }
    }

    void OnGUI() {
        UpdateUI();
    }
}
