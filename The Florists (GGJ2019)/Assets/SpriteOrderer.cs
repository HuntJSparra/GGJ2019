using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteOrderer : MonoBehaviour
{

	public float offset = 0;

    SpriteRenderer sr;

    void Start() {
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update() {
        sr.sortingOrder = (int)(-(transform.position.y+offset)*100);
    }
}
