using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCAnimBehavior : MonoBehaviour {
    private Animator anim;

    private Rigidbody2D rb;

    public bool canMove;

    void Start() {
        anim = gameObject.GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        canMove = true;
        anim.SetInteger("Direction", 1);
    }

    void Update() {
        if(canMove) {
            if(EventTracker.timesUp){
                anim.SetInteger("Direction", 1);
            }

            if (Input.GetAxisRaw("Vertical") > 0) {
                anim.SetInteger("Direction", 1); //up
            } else if (Input.GetAxisRaw("Vertical") < 0) {
                anim.SetInteger("Direction", 0); //down
            } else if (Input.GetAxisRaw("Horizontal") > 0) {
                anim.SetInteger("Direction", 3); //right
            } else if (Input.GetAxisRaw("Horizontal") < 0) {
                anim.SetInteger("Direction", 2); //left
            }
        }

        if ((Mathf.Abs(rb.velocity.x) > 0.1 || Mathf.Abs(rb.velocity.y) > 0.1) & canMove)
            anim.SetBool("Moving", true);
        else
            anim.SetBool("Moving", false);

    }
}
