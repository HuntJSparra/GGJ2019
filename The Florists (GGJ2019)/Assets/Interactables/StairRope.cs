using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StairRope : Doors {

    private StepStool ss;
    private Collider2D col;

    void Start(){
        ss = FindObjectOfType<StepStool>();
        col = gameObject.GetComponent<Collider2D>();
        col.isTrigger = false;
    }

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        if(!EventTracker.hasSS){
        	yield return StartCoroutine(showText("This must be how I can go upstairs"));
        	yield return StartCoroutine(showText("But I am too short to reach it"));
        	EventTracker.foundRope = true;
        }
        else{
        	//place down stepstool
        	yield return StartCoroutine(showText("With the stepstool, you are able to reach the rope and pull down the stairs"));
        	col.isTrigger = true;
        }
        p.unfreeze();
    }
}
