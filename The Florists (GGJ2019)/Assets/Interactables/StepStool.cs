using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StepStool : Interactable {

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        if(!EventTracker.foundRope){
        	yield return StartCoroutine(showText("This doesn't seem to be useful"));
        }
        else{
        	EventTracker.hasSS = true;
        	yield return StartCoroutine(showText("You pick up the step stool"));
        }
        p.unfreeze();
    }
}
