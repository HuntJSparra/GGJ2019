using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Screwdriver : Interactable {

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        if(!EventTracker.foundVent){
        	yield return StartCoroutine(showText("This doesn't seem to be useful"));
        }
        else{
        	EventTracker.hasSD = true;
        	yield return StartCoroutine(showText("You pick up the screwdriver"));
        }
        
        p.unfreeze();
    }
}
