using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField] bool canMove;
    [HideInInspector] public float moveSpeed;
    [SerializeField] float acceleration;
    [HideInInspector] public float jumpSpeed;
    [SerializeField] LayerMask whatIsGround;
    [SerializeField] LayerMask whatIsWall;
    [SerializeField] float raycastExtraLength = 0.01f;

    [HideInInspector] public bool facingRight;
    [HideInInspector] public bool isMoving;
    [HideInInspector] public bool isGrounded;

    CapsuleCollider2D col;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<CapsuleCollider2D>();
        GetComponent<PlayerStats>().UpdatePlayerStats();
    }

    // Update is called once per frame
    void Update() {
        //Horizontal Movement
        float hor = Input.GetAxisRaw("Horizontal");
        if (hor > 0) facingRight = true;
        if (hor < 0) facingRight = false;
        isMoving = (hor != 0) && canMove && (rb.velocity.x != 0);

        if (facingRight) {
            RaycastHit2D hit = Physics2D.Raycast(col.bounds.center, Vector2.right, col.bounds.extents.x + raycastExtraLength, whatIsWall);
            if (hit.collider != null) {
                hor = 0;
            }
        }
        else {
            RaycastHit2D hit = Physics2D.Raycast(col.bounds.center, Vector2.left, col.bounds.extents.x + raycastExtraLength, whatIsWall);
            if (hit.collider != null) {
                hor = 0;
            }
        }

        if (canMove) {
            if (Mathf.Abs(rb.velocity.x) < moveSpeed) {
                rb.velocity += new Vector2(hor * moveSpeed, 0) * acceleration * Time.fixedDeltaTime;
            }
        }

        //Vertical Movement
        isGrounded = CheckGrounded();

        if (isGrounded) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                rb.velocity += new Vector2(0, jumpSpeed);
            }
        }
    }

    private bool CheckGrounded() {
        return Physics2D.CircleCast(col.bounds.center, col.bounds.extents.y, Vector2.down, col.bounds.extents.y + raycastExtraLength, whatIsGround);
    }
}
