using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Viewables : Interactable {

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        yield return StartCoroutine(display()/*display connected image*/);
        p.unfreeze();
    }

    IEnumerator display(){
    	//Switch display to image
    	yield return new WaitForSeconds(5);
    }
}
