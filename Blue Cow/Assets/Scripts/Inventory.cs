using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class Boosts {
    public int count;
    public GameObject ItemUI;
    public Text countUI;
    public FillTimerUI timerUI;
    public PowerUp powerUpControl;
    public bool hasSeen;
}

public class Inventory : MonoBehaviour {

    public Boosts speedBoost;
    public Boosts jumpBoost;
    public Boosts healthBoost;
    public Boosts immortalBoost;
    public Boosts superBoost;

    [Header("ItemInfo")]
    public GameObject itemInfoUI;
    public TextMeshProUGUI itemTitle;
    public Image itemSprite;
    public TextMeshProUGUI itemInfo;

    void Start() {
        itemInfoUI.SetActive(false);
        UpdateUI();
    }

    public void UpdateUI() {
        speedBoost.ItemUI.SetActive(speedBoost.count > 0 && !speedBoost.powerUpControl.active);
        speedBoost.countUI.text = "" + speedBoost.count;

        jumpBoost.ItemUI.SetActive(jumpBoost.count > 0 && !jumpBoost.powerUpControl.active);
        jumpBoost.countUI.text = "" + jumpBoost.count;

        healthBoost.ItemUI.SetActive(healthBoost.count > 0 && !healthBoost.powerUpControl.active);
        healthBoost.countUI.text = "" + healthBoost.count;

        immortalBoost.ItemUI.SetActive(immortalBoost.count > 0 && !immortalBoost.powerUpControl.active);
        immortalBoost.countUI.text = "" + immortalBoost.count;

        superBoost.ItemUI.SetActive(superBoost.count > 0 && !superBoost.powerUpControl.active);
        superBoost.countUI.text = "" + superBoost.count;
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            if (speedBoost.count > 0) {
                if (!speedBoost.powerUpControl.active) {
                    speedBoost.timerUI.StartTimer(speedBoost.powerUpControl.duration);
                    speedBoost.powerUpControl.EnablePowerUp();
                    //if (speedBoost.count == 1) speedBoost.powerUpControl = null;
                    speedBoost.count--;
                    UpdateUI();
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            if (jumpBoost.count > 0) {
                if (!jumpBoost.powerUpControl.active) {
                    jumpBoost.timerUI.StartTimer(jumpBoost.powerUpControl.duration);
                    jumpBoost.powerUpControl.EnablePowerUp();
                    //if (jumpBoost.count == 1) jumpBoost.powerUpControl = null;
                    jumpBoost.count--;
                    UpdateUI();
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3)) {
            if (healthBoost.count > 0) {
                if (!healthBoost.powerUpControl.active) {
                    healthBoost.timerUI.StartTimer(healthBoost.powerUpControl.duration);
                    healthBoost.powerUpControl.EnablePowerUp();
                    //if (healthBoost.count == 1) healthBoost.powerUpControl = null;
                    healthBoost.count--;
                    UpdateUI();
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha4)) {
            if (immortalBoost.count > 0) {
                if (!immortalBoost.powerUpControl.active) {
                    immortalBoost.timerUI.StartTimer(immortalBoost.powerUpControl.duration);
                    immortalBoost.powerUpControl.EnablePowerUp();
                    //if (immortalBoost.count == 1) immortalBoost.powerUpControl = null;
                    immortalBoost.count--;
                    UpdateUI();
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha5)) {
            if (superBoost.count > 0) {
                if (!superBoost.powerUpControl.active) {
                    superBoost.timerUI.StartTimer(superBoost.powerUpControl.duration);
                    superBoost.powerUpControl.EnablePowerUp();
                    //if (superBoost.count == 1) superBoost.powerUpControl = null;
                    superBoost.count--;
                    UpdateUI();
                }
            }
        }
    }

    public void HideItemInfo() {
        itemInfoUI.SetActive(false);
        Time.timeScale = 1;
    }
}
