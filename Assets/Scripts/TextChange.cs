using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    public Text mainText;
    public Button ButtonOne;
    public Button ButtonTwo;

    public bool optionOne;
    public bool optionTwo;


    public void clickOne() {
        mainText.text = "You have pressed the first button";
    }

    public void clickTwo() {
        mainText.text = "You have pressed the second button";
    }
}
