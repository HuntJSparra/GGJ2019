using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OfficeDoor : Interactable {

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        if(EventTracker.Oclosed & !EventTracker.hasKey){
        	yield return StartCoroutine(showText("The door appears to be locked"));
        }
        else if(EventTracker.Oclosed & EventTracker.hasKey){
        	EventTracker.Oclosed = false;
        	yield return StartCoroutine(showText("The door became unlocked and swings open"));
            Destroy(gameObject);
        }
        p.unfreeze();
    }
}
