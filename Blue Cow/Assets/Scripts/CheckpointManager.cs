using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour {

    [HideInInspector] public Transform lastCheckpoint;
    GameObject thePlayer;

    // Start is called before the first frame update
    void Start() {
        thePlayer = FindObjectOfType<PlayerController>().gameObject;
        lastCheckpoint = GameObject.FindWithTag("Spawnpoint").transform;
        RespawnPlayer();
    }

    public void RespawnPlayer() {
        thePlayer.transform.position = lastCheckpoint.position;
        thePlayer.SetActive(true);
    }
}
