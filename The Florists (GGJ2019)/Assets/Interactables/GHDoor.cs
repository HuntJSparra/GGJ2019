using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GHDoor : Interactable {
	bool closed;
	bool inShop;
	bool inRoom;

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        if(closed & inShop){
        	yield return StartCoroutine(showText("There does not appear to be any way to open this door"));
        }
		else if(closed & inRoom){
			//open the door
		}
		else{
			//open path
		}
        p.unfreeze();
    }
}
