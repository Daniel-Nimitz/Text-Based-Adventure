using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    public Text mainText;

    public Button ButtonOne;
    public Button ButtonTwo;
    public Button ButtonThree;
    public Button ButtonFour;

    public Page currentPage;

    //Maybe we can use enums to make each button be generated faster

    public void ClickButtonOne() {
        currentPage = currentPage.buttonOnePageTo;
        mainText.text = currentPage.buttonOnePageTo.description;
        
        //here we turn buttons to active or inactive
        ButtonOne.gameObject.SetActive(currentPage.buttonOnePageTo.buttonOneVisible);
        ButtonTwo.gameObject.SetActive(currentPage.buttonOnePageTo.buttonTwoVisible);
        ButtonThree.gameObject.SetActive(currentPage.buttonOnePageTo.buttonThreeVisible);
        ButtonFour.gameObject.SetActive(currentPage.buttonOnePageTo.buttonFourVisible);

        //Here we update the text for buttons
        ButtonOne.GetComponentInChildren<Text>().text = currentPage.buttonOnePageTo.buttonOneText;
        ButtonTwo.GetComponentInChildren<Text>().text = currentPage.buttonOnePageTo.buttonTwoText;
        ButtonThree.GetComponentInChildren<Text>().text = currentPage.buttonOnePageTo.buttonThreeText;
        ButtonFour.GetComponentInChildren<Text>().text = currentPage.buttonOnePageTo.buttonFourText;
    }
}
