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

    public void ClickButtonOne() {
        mainText.text = currentPage.buttonOnePageTo.description;
        currentPage = currentPage.buttonOnePageTo;
        
        
        //here we turn buttons to active or inactive
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
}
