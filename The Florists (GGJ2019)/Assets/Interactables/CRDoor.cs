using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CRDoor : Interactable {

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        if(EventTracker.CRclosed){
        	yield return StartCoroutine(showText("There does not appear to be any way to open this door"));
        }
        else if(!EventTracker.hasJacket){
            yield return StartCoroutine(showText("It is too cold to go in there"));
        }
    	else{
            //open path
            if(EventTracker.hasDS){
                //option to put down door stop
                EventTracker.usedDS = true;
                EventTracker.CRpropped = true;
                //clear's mist
                yield return StartCoroutine(showText("Because the door isn't keeping it in anymore, the fog in the room clears up"));
            }
            else{
                //fog covers screen
            }
    		
    	}
        p.unfreeze();
    }
}
