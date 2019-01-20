using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewSis : Interactable {

	public Sprite image;

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        yield return StartCoroutine(showImage(image));
        yield return StartCoroutine(showText("oh, yeah, my Sister's Birthday is coming up"));
        EventTracker.foundBday = true;
        p.unfreeze();
    }
}
