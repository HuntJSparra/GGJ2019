using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestInteractions : Interactable {

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        if(/*not found rope*/){
        	yield return StartCoroutine(showText("This doesn't seem to be useful"));
        }
        else{
        	//add stepstool to inventory
        	yield return StartCoroutine(showText("You pick up the step stool"));
        }
        p.unfreeze();
    }
}
