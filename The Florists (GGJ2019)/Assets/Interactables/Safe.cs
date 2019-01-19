using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestInteractions : Interactable {

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        //check hooks
        yield return StartCoroutine(showText("The safe is locked")/*or open and get journel*/);
        p.unfreeze();
    }
}
