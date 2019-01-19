using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestInteractions : Interactable {

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        if(/*doesn't have key and not open*/){
        	yield return StartCoroutine(showText("The door appears to be locked"));
        }
        else if(/*has key and isn't open*/){
        	//uses key and door opens
        	yield return StartCoroutine(showText("The door became unlocked and swings open"));
        }
        else{
        	//open path
        }
        p.unfreeze();
    }
}
