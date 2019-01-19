using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StepStool : Interactable {
	bool hasNeed;

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        if(!hasNeed){
        	yield return StartCoroutine(showText("This doesn't seem to be useful"));
        }
        else{
        	//add stepstool to inventory
        	yield return StartCoroutine(showText("You pick up the step stool"));
        }
        p.unfreeze();
    }
}
