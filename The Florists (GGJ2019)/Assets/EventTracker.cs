using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTracker : MonoBehaviour{
    public static bool hasKey;
    public static bool movedBS;
    public static bool hasJacket;
	public static bool CRclosed;
	public static bool hasDS;
	public static bool Oclosed;
	public static bool foundVent;
	public static bool hasSS;
	public static bool foundRope;
	public static bool hasSD;
	public static bool Vclosed;
	public static bool faucetOn;
	public static bool usedDS;
	public static bool fixedBS;
	public static bool timesUp;

    void Start() {
        CRclosed = true;
        Oclosed = true;
        Vclosed = true;
    }
}
