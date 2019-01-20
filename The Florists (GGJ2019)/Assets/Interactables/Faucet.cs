using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Faucet : Interactable {

    override public IEnumerator run(Freeroam p) {
    	p.freeze();
    	EventTracker.faucetOn = true;
    	yield return StartCoroutine(showText("The water lines are working again"));
    	p.unfreeze();
    }
}
