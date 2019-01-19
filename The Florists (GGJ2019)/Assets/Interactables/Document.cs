using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Documents : Interactable {

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        yield return StartCoroutine(display()/*display connected image*/);
        p.unfreeze();
    }

    IEnumerator display(){
    	//create pop-up with image over background
    	yield return new WaitForSeconds(5);
    }

}
