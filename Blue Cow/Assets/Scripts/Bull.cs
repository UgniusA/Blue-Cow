using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bull : MonoBehaviour {

    [SerializeField] float sightRange;
    [SerializeField] int damage;
    [SerializeField] float movespeed;
    [SerializeField] float chargeSpeed;
    public bool isCharging;
    public bool canCharge;
    [SerializeField] float chargeTime = 0.5f;
    [SerializeField] float chargeResetTime = 1f;
    [SerializeField] SpriteRenderer sr;

    Rigidbody2D rb;
    PlayerController player;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerController>();
        canCharge = true;
    }

    // Update is called once per frame
    void Update() {
        if (canCharge) {
            if (!isCharging) {
                Vector2 dist = player.transform.position - transform.position;
                if (dist.magnitude < sightRange) {
                    sr.flipX = dist.x > 0;
                    float dir = dist.x < 0 ? -1 : 1;
                    StartCoroutine(Charge(dir));
                }
                else {
                    rb.velocity = Vector2.zero;
                }
            }
        }
    }

    IEnumerator Charge(float dir) {
        if (!isCharging) {
            canCharge = false;
            isCharging = true;
            rb.velocity = Vector2.right * dir * chargeSpeed;
            yield return new WaitForSeconds(chargeTime);
            isCharging = false;
            StartCoroutine(WaitTillCharge());
        }
        yield break;
    }

    IEnumerator WaitTillCharge() {
        yield return new WaitForSeconds(chargeResetTime);
        canCharge = true;
        yield break;
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject == player.gameObject) {
            player.GetComponent<Health>().Damage(damage);
            rb.velocity = Vector2.zero;
        }
    }
}
