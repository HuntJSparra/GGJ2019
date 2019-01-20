using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoors : Doors{

	private Collider2D dor;

    void Start(){
        dor = gameObject.GetComponent<Collider2D>();
        dor.isTrigger = true;
    }

    override public IEnumerator run(Freeroam p) {
    	yield return 0;
    }
}
