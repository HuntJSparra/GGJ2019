using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vent : Interactable {
	bool hasSD;
	bool closed;

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        if(closed & !hasSD){
        	yield return StartCoroutine(showText("This is the air vent to the Break Room.\nIt is screwed on pretty tight"));
        }
        else if(closed & hasSD){
        	//remove screwdriver from inventory and unscrew vent
        	yield return StartCoroutine(showText("With the screwdriver, you manage to open the vent"));
        }
        else{
        	//open pathway
        }
        p.unfreeze();
    }
}
