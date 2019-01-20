using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jacket : Interactable {

	private CRDoor door;

    void Start(){
        door = FindObjectOfType<CRDoor>();
    }

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        EventTracker.hasJacket = true;
        door.opened();
        //switch character sprite to jacket version
        yield return StartCoroutine(showText("You grab your jacket"));
        p.unfreeze();
        Destroy(gameObject);
    }
}
