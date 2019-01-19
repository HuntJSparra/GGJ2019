using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestInteractions : Interactable {

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        //add jacket to inventory
        //switch character sprite to jacket version
        yield return StartCoroutine(showText("You grab your jacket"));
        p.unfreeze();
    }
}
