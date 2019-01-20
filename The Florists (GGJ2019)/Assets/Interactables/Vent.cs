using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vent : Interactable {

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        if(EventTracker.Vclosed & !EventTracker.hasSD){
        	yield return StartCoroutine(showText("This is the air vent to the Break Room.\nIt is screwed on pretty tight"));
        	EventTracker.foundVent = true;
        }
        else if(EventTracker.Vclosed & EventTracker.hasSD){
        	//remove screwdriver from inventory and unscrew vent
        	yield return StartCoroutine(showText("With the screwdriver, you manage to open the vent"));
        	EventTracker.Vclosed = false;
            Destroy(gameObject);
        }
        else{
        	//open pathway
        }
        p.unfreeze();
    }
}
