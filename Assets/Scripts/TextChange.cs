using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextChange : MonoBehaviour
{
    public Text mainText;

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
        if (StatisticsTrackerObject.strength > currentPage.neededToPass)
        {
            currentPage = buttonPagesTo;
            mainText.text = buttonPagesTo.description;
        }
        else if (StatisticsTrackerObject.strength < currentPage.neededToPass)
        {
            currentPage = currentPage.PageOnFailure;
            mainText.text = currentPage.description;
        }

        //here we turn buttons to active or inactive
        ButtonActivationChanges(buttonOneActive, ButtonTwoActive, buttonThreeActive, ButtonFourActive);

        //Here we update the text for buttons
        ButtonTextChanges(ButtonOneTextChange, ButtonTwoTextChange, ButtonThreeTextChange, ButtonFourTextChange);
    }


    private void ButtonTextChanges(string ButtonOneTextChange, string ButtonTwoTextChange, string ButtonThreeTextChange, string ButtonFourTextChange)
    {
        ButtonOneText.text = ButtonOneTextChange;
        ButtonTwoText.text = ButtonTwoTextChange;
        ButtonThreeText.text = ButtonThreeTextChange;
        ButtonFourText.text = ButtonFourTextChange;
    }

    private void ButtonActivationChanges(bool buttonOneActive, bool ButtonTwoActive, bool buttonThreeActive, bool ButtonFourActive)
    {
        ButtonOne.gameObject.SetActive(buttonOneActive);
        ButtonTwo.gameObject.SetActive(ButtonTwoActive);
        ButtonThree.gameObject.SetActive(buttonThreeActive);
        ButtonFour.gameObject.SetActive(ButtonFourActive);
    }

    public void ChangesOnButtonOnePress() {

        ChangeOnButtonPress(
            //first we put in the Page information
            currentPage.buttonOnePageTo, 
            //then we put in the information about which buttons are activated/deactivated
            currentPage.buttonOnePageTo.buttonOneVisible, currentPage.buttonOnePageTo.buttonTwoVisible, currentPage.buttonOnePageTo.buttonThreeVisible, currentPage.buttonOnePageTo.buttonFourVisible, 
            //then we put in the information about what the text on buttons changes to be
            currentPage.buttonOnePageTo.buttonOneText, currentPage.buttonOnePageTo.buttonTwoText, currentPage.buttonOnePageTo.buttonThreeText, currentPage.buttonOnePageTo.buttonFourText);
    }

    public void ChangesOnButtonTwoPress() {

        ChangeOnButtonPress(currentPage.buttonTwoPageTo, 

            currentPage.buttonTwoPageTo.buttonOneVisible, currentPage.buttonTwoPageTo.buttonTwoVisible, currentPage.buttonTwoPageTo.buttonThreeVisible, currentPage.buttonTwoPageTo.buttonFourVisible, 
            
            currentPage.buttonTwoPageTo.buttonOneText, currentPage.buttonTwoPageTo.buttonTwoText, currentPage.buttonTwoPageTo.buttonThreeText, currentPage.buttonTwoPageTo.buttonFourText);
    }


    public void ChangesOnButtonThreePress()
    {

        ChangeOnButtonPress(
            //first we put in the Page information
            currentPage.buttonThreePageTo,
            //then we put in the information about which buttons are activated/deactivated
            currentPage.buttonThreePageTo.buttonOneVisible, currentPage.buttonThreePageTo.buttonTwoVisible, currentPage.buttonThreePageTo.buttonThreeVisible, currentPage.buttonThreePageTo.buttonFourVisible,
            //then we put in the information about what the text on buttons changes to be
            currentPage.buttonThreePageTo.buttonOneText, currentPage.buttonThreePageTo.buttonTwoText, currentPage.buttonThreePageTo.buttonThreeText, currentPage.buttonThreePageTo.buttonFourText);
    }

    public void ChangesOnButtonFourPress()
    {

        ChangeOnButtonPress(
            //first we put in the Page information
            currentPage.buttonFourPageTo,
            //then we put in the information about which buttons are activated/deactivated
            currentPage.buttonFourPageTo.buttonOneVisible, currentPage.buttonFourPageTo.buttonTwoVisible, currentPage.buttonFourPageTo.buttonThreeVisible, currentPage.buttonFourPageTo.buttonFourVisible,
            //then we put in the information about what the text on buttons changes to be
            currentPage.buttonFourPageTo.buttonOneText, currentPage.buttonFourPageTo.buttonTwoText, currentPage.buttonFourPageTo.buttonThreeText, currentPage.buttonFourPageTo.buttonFourText);
    }

}
