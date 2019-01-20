using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CRDoor : Doors {

    private Collider2D dor;

    void Start(){
        dor = gameObject.GetComponent<Collider2D>();
        dor.isTrigger = false;
    }

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        if(!EventTracker.hasJacket){
            yield return StartCoroutine(showText("As you open the door, the room beyond is too cold and you step back, letting the door swing close"));
        }
        if(EventTracker.hasDS && !EventTracker.usedDS){
            yield return StartCoroutine(showText("You place the door stop in the door, keeping it open and letting the fog inside clear up"));
            EventTracker.usedDS = true;
        }
        else if(!EventTracker.usedDS){
            yield return StartCoroutine(showText("Inside, there is heavy fog that you cannot see through"));
        }

    

       /*if(EventTracker.CRclosed){
        	yield return StartCoroutine(showText("There does not appear to be any way to open this door"));
        }
        else if(!EventTracker.hasJacket){
            yield return StartCoroutine(showText("It is too cold to go in there"));
        }
    	else{
            //open path
            if(EventTracker.hasDS){
                //option to put down door stop
                EventTracker.usedDS = true;;
                //clear's mist
                yield return StartCoroutine(showText("Because the door isn't keeping it in anymore, the fog in the room clears up"));
            }
            else{
                //fog covers screen
            }
    		
    	}*/
        p.unfreeze();
    }

    public void opened(){
        dor.isTrigger = true;
    }
}
