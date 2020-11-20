using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSave : MonoBehaviour
{
    //here we are referencing which objects have scripts on them.  Since we need the Text Change and StatTracker script information we are referencing the objects with each of these scripts on them
    public GameObject statTrackerObject;
    public GameObject textChangeObject;

    public void Save() {
        //Here we are taking the objects which have the scripts we want to reference and finding the scripts to reference from those objects
        StatTracker statTrackerScript = statTrackerObject.GetComponent<StatTracker>();
        TextChange textChangeScript = textChangeObject.GetComponent<TextChange>();
        //Saving all stat information from StatTracker.cs
        ES3.Save("strength", statTrackerScript.strength);
        ES3.Save("corruption", statTrackerScript.corruption);
        ES3.Save("arcana", statTrackerScript.arcana);
    }
}
