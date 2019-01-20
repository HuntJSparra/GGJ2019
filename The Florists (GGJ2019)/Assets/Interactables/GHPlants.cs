using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GHPlants : Interactable {

	public float toMove;	
	private bool watered;
	public Vector2[] validPos;

	private Rigidbody2D rb;


	void Start() {
		rb = gameObject.GetComponent<Rigidbody2D>();
	}

    override public IEnumerator run(Freeroam p) {
    	p.freeze();
    	yield return StartCoroutine(pushPlant(p));
    	p.unfreeze();
    }

    IEnumerator pushPlant(Freeroam p){
    	if (watered) {
    		yield return StartCoroutine(showText("This plant has been watered. It is now too heavy to move."));
    	} else {

    		//if there is nothing in front of us
    		Rigidbody2D prb = p.GetComponent<Rigidbody2D>();

    		for (float distMoved=0;distMoved<toMove;) {
    			float delta = toMove/50;
    			rb.constraints = RigidbodyConstraints2D.FreezeRotation;
	    		rb.MovePosition((Vector2)transform.position+p.direction*delta);
	    		
	    		prb.MovePosition((Vector2)p.transform.position+p.direction*delta);
	    		distMoved += delta;

	    		yield return new WaitForSeconds(0.01f);
	    		rb.constraints = RigidbodyConstraints2D.FreezeAll;
	    	}
    	}
    }
}
