//The point of this script to to hold information about the current descriptions and button text which should be displayed
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Text Adventure/Page")]
public class Page : ScriptableObject
{
        //We should check if TextArea attribute is helpful or not, is the scroller we built better?
        //[TextArea]
        [Header("Page Texts")]
        public string description;
        public string pageName;

    [Header("Text On Buttons")]
    //these will track what each button will say
    public string buttonOneText;
        public string buttonTwoText;
        public string buttonThreeText;
        public string buttonFourText;

    [Header("Button Activate/Deactivate")]
    //these booleans will controll which buttons appear
    public bool buttonOneVisible;
    public bool buttonTwoVisible;
    public bool buttonThreeVisible;
    public bool buttonFourVisible;

    [Header("Button Page Links")]
    //these track where this page can go
    public Page buttonOnePageTo;
    public Page buttonTwoPageTo;
    public Page buttonThreePageTo;
    public Page buttonFourPageTo;
    
}
