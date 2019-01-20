using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puddle : MonoBehaviour
{
    public bool hasFlower;
    private BoxCollider2D coll;
    public bool water;


    void Start(){
    	coll = gameObject.GetComponent<BoxCollider2D>();
    	coll.enabled = false;
    }

    void Update(){
    	if (water) {
    		coll.enabled = true;
    	} else {
    		coll.enabled = false;
            hasFlower = false;
    	}
    }

    void OnTriggerEnter2D(Collider2D col)
    {
    	//if (EventTracker.faucetOn) {
    	hasFlower = true;
    	print("Flower in Puddle");
    	//col.waterPlant();
    	//}
    }

}
