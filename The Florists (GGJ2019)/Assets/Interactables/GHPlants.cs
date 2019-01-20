using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GHPlants : Interactable {

	public float toMove;	
	private bool watered;
	private Vector2[] validPos;




    override public IEnumerator run(Freeroam p) {
    	p.freeze();
    	yield return StartCoroutine(pushPlant(p));
    	p.unfreeze();
    }

    IEnumerator pushPlant(Freeroam p){
    	if (watered) {
    		yield return StartCoroutine(showText("This plant has been watered. It is now too heavy to move."));
    	} else {
    		for (float distMoved=0;distMoved<toMove;) {
    			float delta = toMove/50;
	    		transform.Translate(p.direction*delta);
	    		p.transform.Translate(p.direction*delta);
	    		distMoved += delta;
	    		yield return new WaitForSeconds(0.01f);
	    	}
    	}
    }
}
