using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BRDoor : Interactable {

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        if(!EventTracker.movedBS){
        	yield return StartCoroutine(showText("The handle rattles, but the door remains closed."));
        }
        p.unfreeze();
    }

    public void delete(){
        Destroy(gameObject);
    }
}
