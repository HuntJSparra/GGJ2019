using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bookshelf : Interactable {

    private BRDoor door;

    void Start(){
        door = FindObjectOfType<BRDoor>();
    }

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        if(!EventTracker.movedBS){
        	//move bookshelf
        	EventTracker.movedBS = true;
            door.delete();
        	yield return StartCoroutine(showText("The bookshelf is back where it is supposed to be, but the books are all out of order"));
        	yield return StartCoroutine(showText("Oh no"));

        }
        else {
            yield return StartCoroutine(showText("The books are all out of order, let me fix that"));
        	yield return StartCoroutine(bookshelf());
        }
        p.unfreeze();
    }

    IEnumerator bookshelf(){
    	//Interact with Bookshelf
    	yield return new WaitForSeconds(5);
    }
}
