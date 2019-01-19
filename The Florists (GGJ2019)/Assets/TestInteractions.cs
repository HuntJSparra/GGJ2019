using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestInteractions : Interactable {

    override public IEnumerator run(Freeroam p) {
        p.freeze();                                          //freeze the player
        // print("frozen");
        yield return StartCoroutine(showText("Test text"));  //Wait for display interactions
        p.unfreeze();                                        //unfreeze after display is finished
        // print("unfrozen");
    }
}
