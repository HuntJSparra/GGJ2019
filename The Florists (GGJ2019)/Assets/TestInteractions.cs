using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestInteractions : MonoBehaviour, Interactable {
    public GameObject textBubble; 



    public void receiveControl(Freeroam p) {
        StartCoroutine(run(p));
        // print("ran");
    }

    public IEnumerator run(Freeroam p) {
        p.freeze();                                 //freeze the player
        // print("frozen");
        yield return StartCoroutine(showText());    //Wait for display interactions
        p.unfreeze();                               //unfreeze after display is finished
        // print("unfrozen");
    }

    public IEnumerator showText(){
        textBubble.SetActive(true);                 //Show text
        // print("true");
        textBubble.transform.Find("Text").GetComponent<Text>().text = "Test text";
        yield return new WaitForFixedUpdate();      //clear Input
        yield return new WaitUntil(() => Input.GetButtonDown("Interact")); //Wait for new input
        // print("exit");
        textBubble.SetActive(false);                //clear display
    }
}
