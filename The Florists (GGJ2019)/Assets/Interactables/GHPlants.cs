using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GHPlants : Interactable {

    override public IEnumerator run(Freeroam p) {
    	p.freeze();
    	yield return StartCoroutine(pushPlant(p));
    	p.unfreeze();
    }

    IEnumerator pushPlant(Freeroam p){
    	yield return new WaitForSeconds(5);
    }
}
