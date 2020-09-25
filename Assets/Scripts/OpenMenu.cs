using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    public GameObject MenuCanvas;

 
    //This will open the menu
    public void ActivateMenu() {
        MenuCanvas.SetActive(true);
    }
    //this will close the menu
    public void CloseMenu()
    {
        MenuCanvas.SetActive(false);
    }

    //this will quit the game
    public void QuitGame() {
        Application.Quit();
    }

}
