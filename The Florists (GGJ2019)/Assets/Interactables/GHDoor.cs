using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestInteractions : Interactable {

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        if(/*closed and in shop*/){
        	yield return StartCoroutine(showText("There does not appear to be any way to open this door"));
        }
		else if(/*closed and in GH*/){
			//open the door
		}
		else{
			//open path
		}
        p.unfreeze();
    }
}
