using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestInteractions : Interactable {

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        if(/*closed*/){
        	yield return StartCoroutine(showText("There does not appear to be any way to open this door"));
        }
        else if(/*have door stop*/){
        	//option to put down door stop
        	//keeps door open
        	//clear's mist
        	yield return StartCoroutine(showText("Because the door isn't keeping it in anymore, the fog in the room clears up"));
    	}
    	else{
    		if(/*doesn't have jacket and door stop*/){
    			yield return StartCoroutine(showText("It is too cold and foggy to go in there"));
    		}
    		else if(/*doesn't have jacket, proped door*/){
    			yield return StartCoroutine(showText("It is too cold to go in there"));
    		}
    		else if(/*has jacket, hasn't proped door*/){
    			yield return StartCoroutine(showText("It is too foggy to go in there"));
    		}
    		else{
    			//open path
    		}
    	}
        p.unfreeze();
    }
}
