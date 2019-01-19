/*******************
* TODO:
*   Abstract out boxcast position
*******************/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeroam : MonoBehaviour {
    public bool canMove;
    public float movementSpeed;

    private Rigidbody2D rb;
    private Collider2D col;

    private int interactableMask;

    void Start() {
        canMove = true;

        rb = gameObject.GetComponent<Rigidbody2D>();
        col = gameObject.GetComponent<Collider2D>();

        interactableMask = LayerMask.GetMask("Interactable");
    }

    void Update() {
        if (canMove) {
            // Movement
            if (Input.GetAxisRaw("Horizontal") == -1) {
                transform.eulerAngles = new Vector3(0, 0, 90);
            } else if (Input.GetAxisRaw("Horizontal") == 1) {
                transform.eulerAngles = new Vector3(0, 0, 270);
            } else if (Input.GetAxisRaw("Vertical") == 1) {
                transform.eulerAngles = new Vector3(0, 0, 0);
            } else if (Input.GetAxisRaw("Vertical") == -1) {
                transform.eulerAngles = new Vector3(0, 0, 180);
            }


            // Interact
            if (Input.GetButtonDown("Interact")) {
                float dist = 0.6f;
                RaycastHit2D[] results = new RaycastHit2D[1];

                col.Raycast(transform.up, results, dist, interactableMask);
                Debug.DrawRay(transform.position, transform.up*dist, Color.red, 0.4f);
                if (results[0].collider != null) {
                    results[0].collider.GetComponent<Interactable>().receiveControl(this);
                }
            }
        }
    }

    void FixedUpdate() {
        if (canMove && (Input.GetButton("Vertical") || Input.GetButton("Horizontal"))) {
            rb.velocity = transform.up*movementSpeed;
        } else {
            rb.velocity = Vector2.zero;
        }
    }


    public void freeze() {
        canMove = false;
    }

    public void unfreeze() {
        canMove = true;
    }
}
