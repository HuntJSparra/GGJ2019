using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestInteractions : Interactable {

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        //add key to inventory
        yield return StartCoroutine(showText("You picked up the office key"));
        p.unfreeze();
    }
}
