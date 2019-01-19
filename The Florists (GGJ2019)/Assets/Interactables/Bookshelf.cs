using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bookshelf : Interactable {

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        //check hooks
        yield return StartCoroutine(bookshelf()/*hook identifier coroutine*/);
        p.unfreeze();
    }

    IEnumerator bookshelf(){
    	//Interact with Bookshelf
    	yield return new WaitForSeconds(5);
    }
}
