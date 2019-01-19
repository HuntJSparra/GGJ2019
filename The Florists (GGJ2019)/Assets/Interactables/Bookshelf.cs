using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestInteractions : Interactable {

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        //check hooks
        yield return StartCoroutine(/*hook identifier coroutine*/);
        p.unfreeze();
    }

    //Interact with Bookshelf
}
