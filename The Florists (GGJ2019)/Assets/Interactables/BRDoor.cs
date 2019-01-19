using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BRDoor : Interactable {
	bool movedBS;

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        if(!movedBS){
        	yield return StartCoroutine(showText("The handle rattles, but the door remains closed."));
        }
        else{
        	//open path
        }
        p.unfreeze();
    }
}
