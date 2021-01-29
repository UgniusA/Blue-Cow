using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField] bool canMove;
    float moveSpeed;
    [SerializeField] float walkSpeed;
    [SerializeField] float runSpeed;
    [SerializeField] float acceleration;
    [SerializeField] float jumpSpeed;
    [SerializeField] LayerMask whatIsGround;
    [SerializeField] Transform groundCheck;

    [HideInInspector] public bool facingRight;
    [HideInInspector] public bool isMoving;
    [HideInInspector] public bool isWalking;
    [HideInInspector] public bool isGrounded;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        //Horizontal Movement
        float hor = Input.GetAxis("Horizontal");
        if (hor > 0) facingRight = true;
        if (hor < 0) facingRight = false;
        isMoving = (hor != 0) && canMove && (rb.velocity.x != 0);
        isWalking = !Input.GetKey(KeyCode.LeftShift);
        moveSpeed = isWalking ? walkSpeed : runSpeed;

        if (canMove) {
            if (Mathf.Abs(rb.velocity.x) < moveSpeed) {
                rb.velocity += new Vector2(hor * moveSpeed, 0) * acceleration * Time.fixedDeltaTime;
            }
        }

        //Vertical Movement
        isGrounded = Physics2D.CircleCast(groundCheck.transform.position, 0.1f, Vector2.down, 0.01f, whatIsGround);

        if (isGrounded) {
            if (Input.GetAxis("Jump") > 0) {
                rb.velocity += new Vector2(0, jumpSpeed);
            }
        }
    }
}
