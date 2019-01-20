using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteOrderer : MonoBehaviour
{
    SpriteRenderer sr;

    void Start() {
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update() {
        sr.sortingOrder = (int)(-transform.position.y*100);
    }
}
