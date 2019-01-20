using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestInteractions : Interactable {
    public Sprite testImage;

    override public IEnumerator run(Freeroam p) {
        p.freeze();                                          //freeze the player
        // print("frozen");
        yield return StartCoroutine(showImage(testImage));  //Wait for display interactions
        yield return StartCoroutine(showText("we"));
        yield return StartCoroutine(showImageAndText(testImage, "we"));
        p.unfreeze();                                        //unfreeze after display is finished
        // print("unfrozen");
    }
}
