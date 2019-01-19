using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTracker : MonoBehaviour{
    public static bool hasKey;

    void Awake() {
        hasKey = false;
    }
}
