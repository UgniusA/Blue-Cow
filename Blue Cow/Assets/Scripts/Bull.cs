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

    int moveDir;
    BoxCollider2D col;
    Rigidbody2D rb;
    PlayerController player;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerController>();
        col = GetComponent<BoxCollider2D>();
        canCharge = true;
    }

    // Update is called once per frame
    void Update() {
        if (canCharge) {
            if (!isCharging) {
                Vector2 dist = player.transform.position - transform.position;
                if (dist.magnitude < sightRange) {
                    sr.flipX = dist.x > 0;
                    moveDir = dist.x < 0 ? -1 : 1;
                    StartCoroutine(Charge(moveDir));
                }
            }
        }
        if (isCharging) {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right * moveDir, col.bounds.extents.x + 0.01f);
            if (hit.collider.gameObject == player) {
                Debug.Log("hit");
                player.GetComponent<Health>().Damage(damage);
                //rb.velocity = Vector2.zero;
                StopCharge();
            }
        }
    }

    IEnumerator Charge(float dir) {
        canCharge = false;
        isCharging = true;
        rb.velocity = Vector2.right * dir * chargeSpeed;
        Debug.Log(Vector2.right * dir * chargeSpeed);
        yield return new WaitForSeconds(chargeTime);
        StopCharge();
        yield break;
    }

    void StopCharge() {
        isCharging = false;
        StartCoroutine(WaitTillCharge());
    }

    IEnumerator WaitTillCharge() {
        yield return new WaitForSeconds(chargeResetTime);
        canCharge = true;
        yield break;
    }
    /*
    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject == player.gameObject) {
            player.GetComponent<Health>().Damage(damage);
            rb.velocity = Vector2.zero;
        }
    }*/
}
