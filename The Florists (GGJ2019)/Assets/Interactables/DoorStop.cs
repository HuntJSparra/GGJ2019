using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorStop : Interactable {

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        EventTracker.hasDS = true;
        Destroy(gameObject);
        yield return StartCoroutine(showText("You picked up a door stop"));
        p.unfreeze();
    }
}
