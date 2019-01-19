using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestInteractions : Interactable {

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        if(/*not moved bookshelf*/){
        	yield return StartCoroutine(showText("The handle rattles, but the door remains closed."));
        }
        else{
        	//open path
        }
        p.unfreeze();
    }
}
