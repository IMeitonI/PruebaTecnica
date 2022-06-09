using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    CircleCollider2D myCollider;
    float horizontal;
    float vertical;
    [SerializeField]float speed =5, jumpForce= 5;
    [SerializeField] LayerMask layerMask;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<CircleCollider2D>();
    }
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate() {
        if (horizontal > 0 || horizontal < 0) {
            rb.AddForce(new Vector2(horizontal * speed, 0f), ForceMode2D.Impulse);
        }
        if (OnGround() && vertical > 0 ) {
            rb.AddForce(new Vector2(0, vertical * jumpForce), ForceMode2D.Impulse);
        }
    }
    bool OnGround() {
        RaycastHit2D raycastHit=Physics2D.BoxCast(myCollider.bounds.center, myCollider.bounds.size, 0f, Vector2.down, 0.1f,layerMask);
        return raycastHit.collider != null;
    }
}
