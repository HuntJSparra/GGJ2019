using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jacket : Interactable {

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        EventTracker.hasJacket = true;
        //switch character sprite to jacket version
        yield return StartCoroutine(showText("You grab your jacket"));
        p.unfreeze();
    }
}
