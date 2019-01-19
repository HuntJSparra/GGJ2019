using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GHLever : Interactable {

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        EventTracker.GHclosed = false;
        yield return StartCoroutine(showText("You hear a door open in the shop"));
        p.unfreeze();
        yield return new WaitForSeconds(30);
        EventTracker.GHclosed = true;
    }
}
