using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OfficeDoor : Interactable {
	bool closed;
	bool hasKey;

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        if(closed & !hasKey){
        	yield return StartCoroutine(showText("The door appears to be locked"));
        }
        else if(closed & hasKey){
        	//uses key and door opens
        	yield return StartCoroutine(showText("The door became unlocked and swings open"));
        }
        else{
        	//open path
        }
        p.unfreeze();
    }
}
