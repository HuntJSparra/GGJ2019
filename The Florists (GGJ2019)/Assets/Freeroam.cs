using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Freeroam : MonoBehaviour {
    public bool canMove;
    public float movementSpeed;

    private Vector2 direction;
    private Rigidbody2D rb;
    private Collider2D col;
    private static Vector3 initPos;

    private int interactableMask;

    void Start() {
        canMove = true;

        direction = Vector2.up;
        initPos = transform.position;

        rb = gameObject.GetComponent<Rigidbody2D>();
        col = gameObject.GetComponent<Collider2D>();

        interactableMask = LayerMask.GetMask("Interactable");
        StartCoroutine(startTimer());
    }

    void Update() {
        if (canMove) {
            if(EventTracker.timesUp){
                reset();
            }
            // Movement
            if (Input.GetAxisRaw("Horizontal") == -1) {
                direction = Vector2.left;
            } else if (Input.GetAxisRaw("Horizontal") == 1) {
                direction = Vector2.right;
            } else if (Input.GetAxisRaw("Vertical") == 1) {
                direction = Vector2.up;
            } else if (Input.GetAxisRaw("Vertical") == -1) {
                direction = Vector2.down;
            }


            // Interact
            if (Input.GetButtonDown("Interact")) {
                float dist = 0.6f;
                RaycastHit2D[] results = new RaycastHit2D[1];

                col.Raycast(direction, results, dist, interactableMask);

                Debug.DrawRay(transform.position+(Vector3)col.offset*transform.localScale.y, direction*dist, Color.red, 0.4f);

                if (results[0].collider != null) {
                    results[0].collider.GetComponent<Interactable>().receiveControl(this);
                    // print("found 1");
                }
            }
        }
    }

    void FixedUpdate() {
        if (canMove) {
            rb.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        }
    }


    public void freeze() {
        canMove = false;
        gameObject.GetComponent<MCAnimBehavior>().canMove = false;
        //freeze timer
    }

    public void unfreeze() {
        canMove = true;
        gameObject.GetComponent<MCAnimBehavior>().canMove = true;
        //unfreeze timer
    }

    private void reset(){
        rb.velocity = Vector2.zero;
        direction = Vector2.up;
        transform.position = initPos;
        EventTracker.timesUp = false;
        StartCoroutine(startTimer());
    }

    public IEnumerator startTimer(){
        yield return new WaitForSecondsRealtime(120);
        EventTracker.timesUp = true;
    }

    public void finalReset(){
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
