using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Safe : Interactable {

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        //check hooks
        if (!EventTracker.plantsWatered || !EventTracker.usedDS || !EventTracker.foundBday || !EventTracker.movedBS) {
        	yield return StartCoroutine(showText("The safe is locked. I need the code to open it.")/*or open and get journel*/);
        	yield return StartCoroutine(showText("There is a hint on a sticky note. \n 'Red Flowers, Encyclopedia of Memory, Sibling's Birthday."));
        } else {
        	yield return StartCoroutine(showText("You enter the code, '83120', and the safe opens. \n There's a jounral inside."));
        	yield return StartCoroutine(showText("'It looks familiar, it must be mine!'"));
        	yield return StartCoroutine(showText("January 1st \n I've been forgetting things a lot. If I remember to write in here then it will be fine, haha. I’ll just use this to save like in a video game!"));
        	yield return StartCoroutine(showText("January 5th \n I forgot a few orders today, and I’ve been forgetting about this journal. Lily wasn’t very happy when I forgot we had plans today. I think she realizes something is wrong."));
        	yield return StartCoroutine(showText("January 7th \n Lily realized I’m forgetting things. I forgot too much and she noticed. I think she might have found my doctors report when she visited. I can’t remember if she did or not."));
        	yield return StartCoroutine(showText("January 9th \n It’s been tough remembering to do anything recently. I’ve been forgetting to water the plants, forgetting to do orders, forgetting what I’m doing."));
        	yield return StartCoroutine(showText("January 11th \n Lily told our parents about my condition. They want me to close the shop and focus on my health. But I can’t do that, I have to preserve my shop. If I close, I’ll lose business and I’ll lose the store. I have to prevent myself from forgetting!"));
        	yield return StartCoroutine(showText("January 13th \n Lily’s birthday is January 20th. Lily is my sister. I have a present for her that I’ll leave with the journal. I can’t remember anything anymore. I’m afraid that I’ll forget about my family and my store."));
        	yield return StartCoroutine(showText("...The entries end there."));

        	if (EventTracker.calendarSeen) {
        		//good end
        		yield return StartCoroutine(showText("Wait a second, oday is January 20th ! That’s what I was forgetting! Well, I was forgetting everything, I suppose. Wait, I need to go now! Before I forget again! I have my journal and Lily’s present; I should be good to go!"));
        		//stubbed, do ending crap
        	} else {
        		audi.Play();
        		yield return StartCoroutine(showText("'I’ve been forgetting everything. This is bad. What will happen if I keep forgetting? I can’t lose my shop, or forget my family. I... I have to preserve it...'"));
        		p.finalReset();
        	}
        }
        

        p.unfreeze();
    }
}
