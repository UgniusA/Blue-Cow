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

    [SerializeField] Boosts speedBoost;
    [SerializeField] Boosts jumpBoost;
    [SerializeField] Boosts healthBoost;
    [SerializeField] Boosts immortalBoost;
    [SerializeField] Boosts superBoost;

    public void UpdateUI() {
        speedBoost.countUI.text = "" + speedBoost.count;
    }
}
