using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestInteractions : MonoBehaviour, Interactable {
    public GameObject textBubble;

    public void receiveControl(Freeroam p) {
        p.freeze();
        run();
        p.unfreeze();
    }

    public void run() {
        textBubble.SetActive(true);
        textBubble.transform.Find("Text").GetComponent<Text>().text = "Test text";
        while (!Input.GetButton("Interact")) {}
    }
}
