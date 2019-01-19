using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestInteractions : Interactable {

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        yield return StartCoroutine(/*display connected image*/);
        p.unfreeze();
    }

    //Switch display to image
}
