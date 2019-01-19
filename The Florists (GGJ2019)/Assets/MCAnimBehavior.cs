using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCAnimBehavior : MonoBehaviour {
    private Animator anim;

    void Start() {
        anim = gameObject.GetComponent<Animator>();
    }

    void Update() {
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
            anim.SetBool("Moving", true);
        else
            anim.SetBool("Moving", false);
    }
}
