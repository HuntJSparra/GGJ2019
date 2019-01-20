using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bookshelf : Interactable {

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        if(!EventTracker.movedBS){
        	//move bookshelf
        	EventTracker.movedBS = true;
        	yield return StartCoroutine(showText("The bookshelf is back where it is supposed to be, but the books are all out of order"));
        	yield return StartCoroutine(showText("Oh no"));
        }
        else if(!EventTracker.fixedBS){
        	yield return StartCoroutine(bookshelf());
        }
        else{
        	//display bookshelf picture
        }
        p.unfreeze();
    }

    IEnumerator bookshelf(){
    	//Interact with Bookshelf
    	yield return new WaitForSeconds(5);
    }
}
