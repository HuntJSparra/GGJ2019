using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ByeFog : MonoBehaviour
{
	public Renderer rend;

    void Start()
    {
        rend = gameObject.GetComponent<Renderer>();
        rend.enabled = true;
    }
    
    void Update()
    {
        if(EventTracker.usedDS){
        	rend.enabled = false;
        }
        else{
            rend.enabled = true;
        }
    }
}
