using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Screwdriver : Interactable {
	bool hasNeed;

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        if(!hasNeed){
        	yield return StartCoroutine(showText("This doesn't seem to be useful"));
        }
        else{
        	//add screwdriver to inventory
        	yield return StartCoroutine(showText("You pick up the screwdriver"));
        }
        
        p.unfreeze();
    }
}
