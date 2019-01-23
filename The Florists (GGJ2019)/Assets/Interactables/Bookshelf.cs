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
            door.unlock();
        	yield return StartCoroutine(showText("The bookshelf is back where it is supposed to be, but the books are all out of order."));
        	yield return StartCoroutine(showText("Oh no"));
        	yield return StartCoroutine(bookshelf());
        }
        p.unfreeze();
    }

    IEnumerator bookshelf(){
    	transform.parent.position = new Vector3(transform.parent.position.x, 7.9f, transform.parent.position.z);
        //audi.Play();
    	yield return StartCoroutine(showText("You put the books back in order."));
        yield return StartCoroutine(showText("'Botany for Beginners', 'Chrysanthemum', 'Encyclopedia of Memory'..."));
        yield return StartCoroutine(showText("'Hi I'm Daisy: A Royal Life', 'Hydrangea, how ya doing?', 'The Dandelion King.'"));
        }
}
