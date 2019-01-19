using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestInteractions : Interactable {

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        //open CRdoor
        yield return StartCoroutine(showText("You hear a door open in the shop"));
        p.unfreeze();
    }
}
