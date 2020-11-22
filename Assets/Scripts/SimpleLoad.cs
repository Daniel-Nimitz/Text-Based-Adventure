using System.Collections;
using UnityEngine.SceneManagement;
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

        //Not sure i did this right.  in the load function the documentation says to do the key then the "default.  Not sure I understood what a default is correctly
        statTrackerScript.importantHappeningsList = ES3.Load("importantHappeningsList", new List<string>());
        statTrackerScript.choiceTraits = ES3.Load("choiceTraits", new List<string>());

        //We load the page we were on
        textChangeScript.currentPage = ES3.Load<Page>("currentPage");

        Debug.Log("The Load Function was called");
    }
}
