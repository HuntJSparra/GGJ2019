using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WateringSwitch : Interactable {

    override public IEnumerator run(Freeroam p) {
    	p.freeze();
    	if(!EventTracker.faucetOn){
    		yield return StartCoroutine(showText("This is labeled as the sprinkler system for another room, but the water lines are off"));
    	}
    	else{
    		yield return StartCoroutine(showText("You hear water falling from beyond the current room"));
    		yield return StartCoroutine(turnOnWater());
    	}
    	p.unfreeze();
    }

    IEnumerator turnOnWater(){
    	yield return new WaitForSeconds(5);
    }
}
