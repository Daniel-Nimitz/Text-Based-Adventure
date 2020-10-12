using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextChange : MonoBehaviour
{
    public Text mainText;
    public Text InventoryText;

    public Button ButtonOne;
    public Button ButtonTwo;
    public Button ButtonThree;
    public Button ButtonFour;

    public TextMeshProUGUI ButtonOneText;
    public TextMeshProUGUI ButtonTwoText;
    public TextMeshProUGUI ButtonThreeText;
    public TextMeshProUGUI ButtonFourText;

    public Page currentPage;

    public StatTracker StatisticsTrackerObject;


    public void ChangeOnButtonPress(Page buttonPagesTo, bool buttonOneActive, bool ButtonTwoActive, bool buttonThreeActive, bool ButtonFourActive, string ButtonOneTextChange, string ButtonTwoTextChange, string ButtonThreeTextChange, string ButtonFourTextChange)
    {
        //This checks if the player has a high enough stat to go to the indicated page.  IF not then they are sent to the failure page
        currentPage = buttonPagesTo;
        mainText.text = buttonPagesTo.description;

        //here we turn buttons to active or inactive
        ButtonActivationChanges(buttonOneActive, ButtonTwoActive, buttonThreeActive, ButtonFourActive);

        //Here we update the text for buttons
        ButtonTextChanges(ButtonOneTextChange, ButtonTwoTextChange, ButtonThreeTextChange, ButtonFourTextChange);
        
        //here we check what items we should gain and lose and check if we passed a check based on items
        InventoryChange(currentPage.gainItem, currentPage.loseItem);

        IncreaseOrDecreaseStats(currentPage.amountToChangeStatBy);
    }

    
    public void ButtonTextChanges(string ButtonOneTextChange, string ButtonTwoTextChange, string ButtonThreeTextChange, string ButtonFourTextChange)
    {
        ButtonOneText.text = ButtonOneTextChange;
        ButtonTwoText.text = ButtonTwoTextChange;
        ButtonThreeText.text = ButtonThreeTextChange;
        ButtonFourText.text = ButtonFourTextChange;
    }

    public void ButtonActivationChanges(bool buttonOneActive, bool ButtonTwoActive, bool buttonThreeActive, bool ButtonFourActive)
    {
        ButtonOne.gameObject.SetActive(buttonOneActive);
        ButtonTwo.gameObject.SetActive(ButtonTwoActive);
        ButtonThree.gameObject.SetActive(buttonThreeActive);
        ButtonFour.gameObject.SetActive(ButtonFourActive);
    }

    //I need to hook this up to the pages options
    //I need to make options to turn the pages differently based on inventory
    public void InventoryChange(string itemToAdd, string itemToRemove)
    {
        StatisticsTrackerObject.inventoryItems.Add(itemToAdd);
        StatisticsTrackerObject.inventoryItems.Remove(itemToRemove);
        string inventoryAsString = string.Join(",", StatisticsTrackerObject.inventoryItems);
        InventoryText.text = "Inventory: " + inventoryAsString;
    }

    public void IncreaseOrDecreaseStats(int howMuchToAddToStat) {
        if (currentPage.StatChangeType == StatType.Strength) {
            StatisticsTrackerObject.AddStrength(howMuchToAddToStat);
        }
        else if (currentPage.StatChangeType == StatType.Arcana) {
            StatisticsTrackerObject.AddArcana(howMuchToAddToStat);
        }

        else if (currentPage.StatChangeType == StatType.Corruption) {
            StatisticsTrackerObject.AddCorruption(howMuchToAddToStat);
        }
    }

    


    public void ButtonOneChoosePageAndFlip() 
    {
        if (StatisticsTrackerObject.inventoryItems.Contains(currentPage.itemToPassButtonOne) || currentPage.itemToPassButtonOne == "")
        {
            switch (currentPage.statToTestButtonOne)
            {
                case StatType.Strength:

                    if (StatisticsTrackerObject.strength > currentPage.neededToPassButtonOne)
                    {
                        ChangesOnButtonOneSucsess();
                    }
                    else if (StatisticsTrackerObject.strength <= currentPage.neededToPassButtonOne)
                    {
                        ChangesOnButtonOneFailure();
                    }
                    break;

                case StatType.Arcana:

                    if (StatisticsTrackerObject.arcana > currentPage.neededToPassButtonOne)
                    {
                        ChangesOnButtonOneSucsess();
                    }
                    else if (StatisticsTrackerObject.arcana <= currentPage.neededToPassButtonOne)
                    {
                        ChangesOnButtonOneFailure();
                    }
                    break;

                case StatType.Corruption:

                    if (StatisticsTrackerObject.corruption > currentPage.neededToPassButtonOne)
                    {
                        ChangesOnButtonOneSucsess();
                    }
                    else if (StatisticsTrackerObject.corruption <= currentPage.neededToPassButtonOne)
                    {
                        ChangesOnButtonOneFailure();
                    }
                    break;

                case StatType.None:
                    ChangesOnButtonOneSucsess();
                    break;

                default:
                    print("Something has gone wrong, please let the developers know what was happening before you recieved this message." +
                        "When checking wether one of your stats was too high or low for an action to be taken something went wrong.");
                    break;
            }
        }
        else if (!StatisticsTrackerObject.inventoryItems.Contains(currentPage.itemToPassButtonOne))
        {
            ChangesOnButtonOneFailure();
        }
        else { 
        
        print("Something went wrong with the item or stat check on button one.");
        }
        
    }

    private void ChangesOnButtonOneFailure()
    {
        ChangeOnButtonPress(
        //first we put in the Page information
        currentPage.PageOnFailureButtonOne,
        //then we put in the information about which buttons are activated/deactivated
        currentPage.PageOnFailureButtonOne.buttonOneVisible, currentPage.PageOnFailureButtonOne.buttonTwoVisible, currentPage.PageOnFailureButtonOne.buttonThreeVisible, currentPage.PageOnFailureButtonOne.buttonFourVisible,
        //then we put in the information about what the text on buttons changes to be
        currentPage.PageOnFailureButtonOne.buttonOneText, currentPage.PageOnFailureButtonOne.buttonTwoText, currentPage.PageOnFailureButtonOne.buttonThreeText, currentPage.PageOnFailureButtonOne.buttonFourText
        );
        
        
    }

    private void ChangesOnButtonOneSucsess()
    {

        ChangeOnButtonPress(
            //first we put in the Page information
            currentPage.buttonOnePageTo,
            //then we put in the information about which buttons are activated/deactivated
            currentPage.buttonOnePageTo.buttonOneVisible, currentPage.buttonOnePageTo.buttonTwoVisible, currentPage.buttonOnePageTo.buttonThreeVisible, currentPage.buttonOnePageTo.buttonFourVisible,
            //then we put in the information about what the text on buttons changes to be
            currentPage.buttonOnePageTo.buttonOneText, currentPage.buttonOnePageTo.buttonTwoText, currentPage.buttonOnePageTo.buttonThreeText, currentPage.buttonOnePageTo.buttonFourText
            );
    }


    public void ButtonTwoChoosePageAndFlip()
    {
        if (StatisticsTrackerObject.inventoryItems.Contains(currentPage.itemToPassButtonTwo) || currentPage.itemToPassButtonTwo == "")
        {
            switch (currentPage.statToTestButtonTwo)
            {
                case StatType.Strength:

                    if (StatisticsTrackerObject.strength >= currentPage.neededToPassButtonTwo)
                    {
                        ChangesOnButtonTwoSucsess();
                    }
                    else if (StatisticsTrackerObject.strength < currentPage.neededToPassButtonTwo)
                    {
                        ChangesOnButtonTwoFailure();
                    }
                    break;

                case StatType.Arcana:

                    if (StatisticsTrackerObject.arcana >= currentPage.neededToPassButtonTwo)
                    {
                        ChangesOnButtonTwoSucsess();
                    }
                    else if (StatisticsTrackerObject.arcana < currentPage.neededToPassButtonTwo)
                    {
                        ChangesOnButtonTwoFailure();
                    }
                    break;

                case StatType.Corruption:

                    if (StatisticsTrackerObject.corruption >= currentPage.neededToPassButtonTwo)
                    {
                        ChangesOnButtonTwoSucsess();
                    }
                    else if (StatisticsTrackerObject.corruption < currentPage.neededToPassButtonTwo)
                    {
                        ChangesOnButtonTwoFailure();
                    }
                    break;

                case StatType.None:
                    ChangesOnButtonTwoSucsess();
                    break;

                default:
                    print("Something has gone wrong, please let the developers know what was happening before you recieved this message." +
                        "When checking wether one of your stats was too high or low for an action to be taken on after pressing button 2 something went wrong.");
                    break;
            }

        }
        else if (!StatisticsTrackerObject.inventoryItems.Contains(currentPage.itemToPassButtonTwo))
        {
            ChangesOnButtonTwoFailure();
        }
        else
        {
            print("Something went wrong with the item or stat check on button one.  Probably based on the item check.");
        }

    }





    public void ChangesOnButtonTwoSucsess() {

        ChangeOnButtonPress(currentPage.buttonTwoPageTo, 

            currentPage.buttonTwoPageTo.buttonOneVisible, currentPage.buttonTwoPageTo.buttonTwoVisible, currentPage.buttonTwoPageTo.buttonThreeVisible, currentPage.buttonTwoPageTo.buttonFourVisible, 
            
            currentPage.buttonTwoPageTo.buttonOneText, currentPage.buttonTwoPageTo.buttonTwoText, currentPage.buttonTwoPageTo.buttonThreeText, currentPage.buttonTwoPageTo.buttonFourText
            //These deal with what buttons might be aded or taken away
           
            );
    }

    private void ChangesOnButtonTwoFailure()
    {
        ChangeOnButtonPress(
        //first we put in the Page information
        currentPage.PageOnFailureButtonTwo,
        //then we put in the information about which buttons are activated/deactivated
        currentPage.PageOnFailureButtonTwo.buttonOneVisible, currentPage.PageOnFailureButtonTwo.buttonTwoVisible, currentPage.PageOnFailureButtonTwo.buttonThreeVisible, currentPage.PageOnFailureButtonTwo.buttonFourVisible,
        //then we put in the information about what the text on buttons changes to be
        currentPage.PageOnFailureButtonTwo.buttonOneText, currentPage.PageOnFailureButtonTwo.buttonTwoText, currentPage.PageOnFailureButtonTwo.buttonThreeText, currentPage.PageOnFailureButtonTwo.buttonFourText
        
        );
    }



    public void ButtonThreeChoosePageAndFlip()
    {
        if (StatisticsTrackerObject.inventoryItems.Contains(currentPage.itemToPassButtonThree) || currentPage.itemToPassButtonThree == "")
        {
            switch (currentPage.statToTestButtonThree)
            {
                case StatType.Strength:

                    if (StatisticsTrackerObject.strength >= currentPage.neededToPassButtonThree)
                    {
                        ChangesOnButtonThreeSucsess();
                    }
                    else if (StatisticsTrackerObject.strength < currentPage.neededToPassButtonThree)
                    {
                        ChangesOnButtonThreeFailure();
                    }
                    break;

                case StatType.Arcana:

                    if (StatisticsTrackerObject.arcana >= currentPage.neededToPassButtonThree)
                    {
                        ChangesOnButtonThreeSucsess();
                    }
                    else if (StatisticsTrackerObject.arcana < currentPage.neededToPassButtonThree)
                    {
                        ChangesOnButtonThreeFailure();
                    }
                    break;

                case StatType.Corruption:

                    if (StatisticsTrackerObject.corruption >= currentPage.neededToPassButtonThree)
                    {
                        ChangesOnButtonThreeSucsess();
                    }
                    else if (StatisticsTrackerObject.corruption < currentPage.neededToPassButtonThree)
                    {
                        ChangesOnButtonThreeFailure();
                    }
                    break;

                case StatType.None:
                    ChangesOnButtonThreeSucsess();
                    break;

                default:
                    print("Something has gone wrong, please let the developers know what was happening before you recieved this message." +
                        "When checking wether one of your stats was too high or low for an action to be taken on after pressing button 2 something went wrong.");
                    break;
            }
        }
        else if (!StatisticsTrackerObject.inventoryItems.Contains(currentPage.itemToPassButtonThree))
        {
            ChangesOnButtonThreeFailure();
        }
        else
        {

            print("Something went wrong with the item or stat check on button one.");
        }

    }

    private void ChangesOnButtonThreeFailure()
    {
        ChangeOnButtonPress(
        //first we put in the Page information
        currentPage.PageOnFailureButtonThree,
        //then we put in the information about which buttons are activated/deactivated
        currentPage.PageOnFailureButtonThree.buttonOneVisible, currentPage.PageOnFailureButtonThree.buttonTwoVisible, currentPage.PageOnFailureButtonThree.buttonThreeVisible, currentPage.PageOnFailureButtonThree.buttonFourVisible,
        //then we put in the information about what the text on buttons changes to be
        currentPage.PageOnFailureButtonThree.buttonOneText, currentPage.PageOnFailureButtonThree.buttonTwoText, currentPage.PageOnFailureButtonThree.buttonThreeText, currentPage.PageOnFailureButtonThree.buttonFourText
       
        );
    }


    public void ChangesOnButtonThreeSucsess()
    {

        ChangeOnButtonPress(
            //first we put in the Page information
            currentPage.buttonThreePageTo,
            //then we put in the information about which buttons are activated/deactivated
            currentPage.buttonThreePageTo.buttonOneVisible, currentPage.buttonThreePageTo.buttonTwoVisible, currentPage.buttonThreePageTo.buttonThreeVisible, currentPage.buttonThreePageTo.buttonFourVisible,
            //then we put in the information about what the text on buttons changes to be
            currentPage.buttonThreePageTo.buttonOneText, currentPage.buttonThreePageTo.buttonTwoText, currentPage.buttonThreePageTo.buttonThreeText, currentPage.buttonThreePageTo.buttonFourText
           
            );
    }




    public void ButtonFourChoosePageAndFlip()
    {
        if (StatisticsTrackerObject.inventoryItems.Contains(currentPage.itemToPassButtonFour) || currentPage.itemToPassButtonFour == "")
        {
            switch (currentPage.statToTestButtonFour)
            {
                case StatType.Strength:

                    if (StatisticsTrackerObject.strength >= currentPage.neededToPassButtonFour)
                    {
                        ChangesOnButtonThreeSucsess();
                    }
                    else if (StatisticsTrackerObject.strength < currentPage.neededToPassButtonFour)
                    {
                        ChangesOnButtonThreeFailure();
                    }
                    break;

                case StatType.Arcana:

                    if (StatisticsTrackerObject.arcana >= currentPage.neededToPassButtonFour)
                    {
                        ChangesOnButtonFourSucsess();
                    }
                    else if (StatisticsTrackerObject.arcana < currentPage.neededToPassButtonFour)
                    {
                        ChangesOnButtonFourFailure();
                    }
                    break;

                case StatType.Corruption:

                    if (StatisticsTrackerObject.corruption >= currentPage.neededToPassButtonFour)
                    {
                        ChangesOnButtonFourSucsess();
                    }
                    else if (StatisticsTrackerObject.corruption < currentPage.neededToPassButtonFour)
                    {
                        ChangesOnButtonFourFailure();
                    }
                    break;

                case StatType.None:
                    ChangesOnButtonFourSucsess();
                    break;

                default:
                    print("Something has gone wrong, please let the developers know what was happening before you recieved this message." +
                        "When checking wether one of your stats was too high or low for an action to be taken on after pressing button 2 something went wrong.");
                    break;
            }
        }
        else if (!StatisticsTrackerObject.inventoryItems.Contains(currentPage.itemToPassButtonFour))
        {
            ChangesOnButtonFourFailure();
        }
        else
        {

            print("Something went wrong with the item or stat check on button one.");
        }

    }

   

    public void ChangesOnButtonFourSucsess()
    {

        ChangeOnButtonPress(
            //first we put in the Page information
            currentPage.buttonFourPageTo,
            //then we put in the information about which buttons are activated/deactivated
            currentPage.buttonFourPageTo.buttonOneVisible, currentPage.buttonFourPageTo.buttonTwoVisible, currentPage.buttonFourPageTo.buttonThreeVisible, currentPage.buttonFourPageTo.buttonFourVisible,
            //then we put in the information about what the text on buttons changes to be
            currentPage.buttonFourPageTo.buttonOneText, currentPage.buttonFourPageTo.buttonTwoText, currentPage.buttonFourPageTo.buttonThreeText, currentPage.buttonFourPageTo.buttonFourText
            );
    }

    private void ChangesOnButtonFourFailure()
    {
        ChangeOnButtonPress(
        //first we put in the Page information
        currentPage.PageOnFailureButtonFour,
        //then we put in the information about which buttons are activated/deactivated
        currentPage.PageOnFailureButtonFour.buttonOneVisible, currentPage.PageOnFailureButtonFour.buttonTwoVisible, currentPage.PageOnFailureButtonFour.buttonThreeVisible, currentPage.PageOnFailureButtonFour.buttonFourVisible,
        //then we put in the information about what the text on buttons changes to be
        currentPage.PageOnFailureButtonFour.buttonOneText, currentPage.PageOnFailureButtonFour.buttonTwoText, currentPage.PageOnFailureButtonFour.buttonThreeText, currentPage.PageOnFailureButtonFour.buttonFourText
       
        );
    }

}
