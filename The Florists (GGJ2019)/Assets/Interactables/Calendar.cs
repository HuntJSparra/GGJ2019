using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calendar : Interactable
{
    // Start is called before the first frame update
    


    override public IEnumerator run(Freeroam p) {
        p.freeze();
        EventTracker.calendarSeen = true;
        yield return StartCoroutine(showText("Today is January 20th"));
        p.unfreeze();
    }
}
