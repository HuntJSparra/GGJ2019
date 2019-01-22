using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puddle : MonoBehaviour
{
    public bool hasFlower;
    private BoxCollider2D coll;
    public bool water;
    public bool displaySprite;
    public int num;


    void Start(){
    	coll = gameObject.GetComponent<BoxCollider2D>();
    	coll.enabled = true;
        num=0;
    }

    void Update(){
        if (!EventTracker.faucetOn || !displaySprite) {
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
            } else {
                gameObject.GetComponent<SpriteRenderer>().enabled = true;
            }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
    	//if (EventTracker.faucetOn) {
        num+=1;
    	hasFlower = true;
    	print("Flower in Puddle");
    	//col.waterPlant();
    	//}
    }

    void OnTriggerExit2D(Collider2D col)
    {
        num-=1;
        if(num==0){
            hasFlower = false;
        }
    }
}
