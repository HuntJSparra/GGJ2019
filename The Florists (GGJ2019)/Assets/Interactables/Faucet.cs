using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Faucet : Interactable {

    override public IEnumerator run(Freeroam p) {
    	p.freeze();
    	if(!EventTracker.foundWS){
    		yield return StartCoroutine(showText("This apears to be what controls the water lines"));
    	}
    	else{
    		EventTracker.faucetOn = true;
    		yield return StartCoroutine(showText("The water lines are working again"));
    	}
    	p.unfreeze();
    }
}
