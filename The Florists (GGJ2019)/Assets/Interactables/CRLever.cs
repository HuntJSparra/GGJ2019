using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CRLever : Interactable {

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        EventTracker.CRclosed = false;
        yield return StartCoroutine(showText("You hear a door open in the shop"));
        p.unfreeze();
        yield return new WaitForSeconds(30);
        if(!usedDS){
        	EventTracker.CRclosed = true;
        }
    }
}
