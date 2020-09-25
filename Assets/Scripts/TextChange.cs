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

    //Maybe we can use enums to make each button be generated faster

    public void ClickButtonOne(){
        mainText.text = currentPage.buttonOnePageTo.description;
        currentPage = currentPage.buttonOnePageTo;
        
        
        //here we turn buttons to active or inactive =.  These are true or false statements.
        ButtonOne.gameObject.SetActive(currentPage.buttonOnePageTo.buttonOneVisible);
        ButtonTwo.gameObject.SetActive(currentPage.buttonOnePageTo.buttonTwoVisible);
        ButtonThree.gameObject.SetActive(currentPage.buttonOnePageTo.buttonThreeVisible);
        ButtonFour.gameObject.SetActive(currentPage.buttonOnePageTo.buttonFourVisible);

        //Here we update the text for buttons
        ButtonOneText.text = currentPage.buttonOnePageTo.buttonOneText;
        ButtonTwoText.text = currentPage.buttonOnePageTo.buttonTwoText;
        ButtonThreeText.text = currentPage.buttonOnePageTo.buttonThreeText;
        ButtonFourText.text = currentPage.buttonOnePageTo.buttonFourText;
    }

    




    //This function is the base funtion we use to make button pressing UI changes in other buttons
    /*buttonPagesTo should be the Page which the button will take us to when we click it so it will be something like currentPage.buttonOnePagesTo
     * button-----Active should all be represented by something like buttonPagesTo.buttonOne visible
     * 
     * 
     * 
     * NOTE: For Some reason I cannot get the buttonPagesTo to be referenced when I try to call this funtion
     */
    public void ChangeOnButtonPress(Page buttonPagesTo, bool buttonOneActive, bool ButtonTwoActive, bool buttonThreeActive, bool ButtonFourActive, string ButtonOneTextChange, string ButtonTwoTextChange, string ButtonThreeTextChange, string ButtonFourTextChange)
    {
        mainText.text = buttonPagesTo.description;
        currentPage = buttonPagesTo;


        //here we turn buttons to active or inactive
        ButtonOne.gameObject.SetActive(buttonOneActive);
        ButtonTwo.gameObject.SetActive(ButtonTwoActive);
        ButtonThree.gameObject.SetActive(buttonThreeActive);
        ButtonFour.gameObject.SetActive(ButtonFourActive);

        //Here we update the text for buttons
        ButtonOneText.text = ButtonOneTextChange;
        ButtonTwoText.text = ButtonTwoTextChange;
        ButtonThreeText.text = ButtonThreeTextChange;
        ButtonFourText.text = ButtonFourTextChange;
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


}
