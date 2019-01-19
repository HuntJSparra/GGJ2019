using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestInteractions : Interactable {

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        if(/*don't have step stool*/){
        	yield return StartCoroutine(showText("This must be how I can go upstairs"));
        	yield return StartCoroutine(showText("But I am too short to reach it"));
        	//step stool hook available
        }
        else{
        	//place down stepstool
        	yield return StartCoroutine(showText("With the stepstool, you are able to reach the rope and pull down the stairs"));
        	//rope & stepstool replaced with stairs
        }
        p.unfreeze();
    }
}
