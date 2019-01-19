using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WateringSwitch : Interactable {

    override public IEnumerator run(Freeroam p) {
    	p.freeze();
    	if(!EventTracker.faucetOn){
    		yield return StartCoroutine(showText("This is the watering system for the flowers, but the water isn't on"));
    		EventTracker.foundWS = true;
    	}
    	else{
    		yield return StartCoroutine(showText(turnOnWater()));
    	}
    	p.unfreeze();
    }

    IEnumerator turnOnWater(){
    	yield return new WaitForSeconds(5);
    }
}
