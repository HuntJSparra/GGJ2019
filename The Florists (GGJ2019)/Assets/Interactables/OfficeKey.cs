using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OfficeKey : Interactable {

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        EventTracker.hasKey = true;
        yield return StartCoroutine(showText("You picked up the office key"));
        p.unfreeze();
        Destroy(gameObject);
    }
}
