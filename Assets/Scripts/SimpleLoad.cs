using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleLoad : MonoBehaviour
{
    public GameObject statTrackerObject;
    public GameObject textChangeObject;

    public void Load()
    {
        //Here we are taking the objects which have the scripts we want to reference and finding the scripts to reference from those objects
        StatTracker statTrackerScript = statTrackerObject.GetComponent<StatTracker>();
        TextChange textChangeScript = textChangeObject.GetComponent<TextChange>();
        statTrackerScript.strength = ES3.Load<int>("strength");
        statTrackerScript.corruption = ES3.Load<int>("corruption");
        statTrackerScript.arcana = ES3.Load<int>("arcana");
        Debug.Log("The Load Function was called");
    }
}
