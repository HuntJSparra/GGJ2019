using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vent : Doors {

    private Collider2D col;

    void Start(){
        col = gameObject.GetComponent<Collider2D>();
        col.isTrigger = false;
    }

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        if(EventTracker.Vclosed && EventTracker.hasSD){
            //remove screwdriver from inventory and unscrew vent
            yield return StartCoroutine(showText("With the screwdriver, you manage to open the vent"));
            EventTracker.Vclosed = false;
            col.isTrigger = true;
        }
        else if(!EventTracker.hasSD){
        	yield return StartCoroutine(showText("This is the air vent to the Break Room.\nIt is screwed on pretty tight"));
        	EventTracker.foundVent = true;
        }
        p.unfreeze();
    }
}
