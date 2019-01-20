using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OfficeDoor : Doors {

    public Collider2D dor;

    void Start(){
        dor = gameObject.GetComponent<Collider2D>();
    }

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        if(EventTracker.Oclosed == true && EventTracker.hasKey == true){
            EventTracker.Oclosed = false;
            yield return StartCoroutine(showText("The door became unlocked and swings open"));
            dor.isTrigger = true;
        }
        else{
        	yield return StartCoroutine(showText("The door appears to be locked"));
        }
        p.unfreeze();
    }
}
