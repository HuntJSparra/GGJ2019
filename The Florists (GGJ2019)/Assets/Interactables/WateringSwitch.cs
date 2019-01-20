using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WateringSwitch : Interactable {


    public Puddle[] puddles;
    private bool allOn;
    public bool debugWater;

    override public IEnumerator run(Freeroam p) {
    	p.freeze();
    	if(!EventTracker.faucetOn && !debugWater){
    		yield return StartCoroutine(showText("This is labeled as the sprinkler system for another room, but the water lines are off"));
    	}
    	else{
    		yield return StartCoroutine(showText("You hear water falling from beyond the current room"));
    		yield return StartCoroutine(turnOnWater());
    	}
    	p.unfreeze();
    }

    IEnumerator turnOnWater(){
        allOn = true;

        foreach (Puddle p in puddles) {
            p.water = true;
            yield return new WaitForSeconds(0.1f);
            if (!p.hasFlower) {
                allOn = false; 
                yield return new WaitForSeconds(0.1f);
            }
            p.water = false;
        }
        if (allOn) {
            //print("Puzzle complete!");
            EventTracker.plantsWatered = true;
        }
    	yield return new WaitForSeconds(0);
    }
}
