using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GHPlants : Interactable {

    override public IEnumerator run(Freeroam p) {
    	p.freeze();
    	yield return StartCoroutine(pushPlant());
    	p.unfreeze();
    }

    IEnumerator pushPlant(){
    	yield return new WaitForSeconds(5);
    }
}
