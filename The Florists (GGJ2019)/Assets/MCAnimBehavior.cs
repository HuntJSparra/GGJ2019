using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCAnimBehavior : MonoBehaviour {
    private Animator anim;

    private Rigidbody2D rb;

    void Start() {
        anim = gameObject.GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update() {
        if (Input.GetAxisRaw("Vertical") > 0) {
            anim.SetInteger("Direction", 1);
        } else if (Input.GetAxisRaw("Vertical") < 0) {
            anim.SetInteger("Direction", 0);
        } else if (Input.GetAxisRaw("Horizontal") > 0) {
            anim.SetInteger("Direction", 3);
        } else if (Input.GetAxisRaw("Horizontal") < 0) {
            anim.SetInteger("Direction", 2);
        }

        if (Mathf.Abs(rb.velocity.x) > 0.1 || Mathf.Abs(rb.velocity.y) > 0.1)
            anim.SetBool("Moving", true);
        else
            anim.SetBool("Moving", false);
    }
}
