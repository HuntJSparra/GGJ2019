using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

abstract public class Interactable : MonoBehaviour{
	public GameObject textBubble; 
    public GameObject imageBubble;

    public void receiveControl(Freeroam p){
    	StartCoroutine(run(p));
    }

    public abstract IEnumerator run(Freeroam p);

    public IEnumerator showText(string display){
    	textBubble.SetActive(true);                                             //Show text
        textBubble.transform.Find("Text").GetComponent<Text>().text = display;
        yield return new WaitForFixedUpdate();                                  //clear Input
        yield return new WaitUntil(() => Input.GetButtonDown("Interact"));      //Wait for new input
        textBubble.SetActive(false);   
    }

    public IEnumerator showImage(Sprite image) {
        imageBubble.SetActive(true);
        imageBubble.GetComponent<Image>().sprite = image;
        yield return new WaitForFixedUpdate();                                  //clear Input
        yield return new WaitUntil(() => Input.GetButtonDown("Interact"));      //Wait for new input
        imageBubble.SetActive(false);
    }

    public IEnumerator showImageAndText(Sprite image, string text) {
        textBubble.SetActive(true);                                             //Show text
        textBubble.transform.Find("Text").GetComponent<Text>().text = text;
        imageBubble.SetActive(true);
        imageBubble.GetComponent<Image>().sprite = image;
        yield return new WaitForFixedUpdate();                                  //clear Input
        yield return new WaitUntil(() => Input.GetButtonDown("Interact"));      //Wait for new input
        textBubble.SetActive(false);
        imageBubble.SetActive(false);
    }
}
