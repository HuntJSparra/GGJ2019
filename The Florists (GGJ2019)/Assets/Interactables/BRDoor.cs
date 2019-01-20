using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BRDoor : Doors {

    private Collider2D col;

    void Start(){
        col = gameObject.GetComponent<Collider2D>();
        col.isTrigger = false;
    }

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        if(!EventTracker.movedBS){
        	yield return StartCoroutine(showText("The handle rattles, but the door remains closed."));
        }
        p.unfreeze();
    }

    public void unlock(){
        col.isTrigger = true;
    }
}
