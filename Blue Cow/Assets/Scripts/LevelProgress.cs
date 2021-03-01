using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelProgress : MonoBehaviour {

    [SerializeField] float levelTimer;
    float cowTime;
    float playerProgress;

    [SerializeField] Slider cowProgressSlider;
    [SerializeField] Slider playerProgressSlider;

    PlayerController pc;
    Vector2 startPos;
    Vector2 endPos;
    float totalDistance;

    // Start is called before the first frame update
    void Start() {
        startPos = GameObject.FindWithTag("Spawnpoint").transform.position;
        endPos = transform.position;
        totalDistance = endPos.x - startPos.x;
        cowTime = levelTimer * 0.2f;
    }

    // Update is called once per frame
    void Update() {
        cowTime += Time.deltaTime;
        cowTime = Mathf.Clamp(cowTime, 0, levelTimer);

        cowProgressSlider.value = cowTime / levelTimer;

        float current = pc.transform.position.x - startPos.x;
        playerProgress = current / totalDistance;
        playerProgressSlider.value = playerProgress;
    }
}
