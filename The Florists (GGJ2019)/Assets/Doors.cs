using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

abstract public class Doors : Interactable {
	public Camera targetCam;
	public Vector2 targetPos;

    void OnTriggerEnter2D(Collider2D col)
    {

    	//print("Player is in door");

    	//Teleport player to new location

    	//Change active camera to targetCamera
    	Camera.main.enabled = false;
    	targetCam.enabled = true;
    	col.transform.position = targetPos;
    }
}
