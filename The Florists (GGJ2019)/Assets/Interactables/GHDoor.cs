using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GHDoor : Interactable {
	

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        if(EventTracker.GHclosed & EventTracker.inShop){
        	yield return StartCoroutine(showText("There does not appear to be any way to open this door"));
        }
		else if(EventTracker.GHclosed & EventTracker.inRoom){
			//open the door
		}
		else{
			//open path
		}
        p.unfreeze();
    }
}
