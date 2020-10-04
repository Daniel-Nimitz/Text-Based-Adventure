//The point of this script to to hold information about the current descriptions and button text which should be displayed
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum StatType { None, Strength, Arcana, Corruption };


[CreateAssetMenu(menuName = "Text Adventure/Page")]
public class Page : ScriptableObject
{
    //We should check if TextArea attribute is helpful or not, is the scroller we built better?
    [Header("Page Texts")]
    public string pageName;
    public string description;


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

    [Header("Change Stats")]
    public StatType StatChangeType;
    public int amountToChangeStatBy;

    [Header("Button 1 Stat Pass/Fail")]
    public StatType statToTestButtonOne;
    public int neededToPassButtonOne;
    public Page PageOnFailureButtonOne;

    [Header("Button 2 Stat Pass/Fail")]
    public StatType statToTestButtonTwo;
    public int neededToPassButtonTwo;
    public Page PageOnFailureButtonTwo;

    [Header("Button 3 Stat Pass/Fail")]
    public StatType statToTestButtonThree;
    public int neededToPassButtonThree;
    public Page PageOnFailureButtonThree;

    [Header("Button 4 Stat Pass/Fail")]
    public StatType statToTestButtonFour;
    public int neededToPassButtonFour;
    public Page PageOnFailureButtonFour;

    [Header("Items")]
    public string gainItem;
    public string loseItem;



    //add next part to track that if a certain stat is under a certain amount then we will go to a certain page
    //need a pages to point to if they are below a stat
    //need a stat to check
    //need a number to tell us what number to check at
    //then write in all this info into a meathod in TextChange.cs to check if the stat is below the number or not.
    //If the stat is below the necessary number then go to the appointed page
    //If the stat is above the necesssary number then work as normal so basically just return
}
