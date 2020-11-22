using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenMenu : MonoBehaviour
{
    public GameObject MenuCanvas;
    public GameObject StatisticsMenu;
    public GameObject AreYouSureMenu;
    public GameObject OptionsMenu;

    


    //This will open the menu
    public void ActivateMenu()
    {
        MenuCanvas.SetActive(true);
    }
    //this will close the menu
    public void CloseMenu()
    {
        MenuCanvas.SetActive(false);
    }


    //this will quit the game
    public void QuitGame()
    {
        Application.Quit();
    }

    public void ReloadScene() {
        Scene currentScene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(currentScene.name);

    }

    public void ActivateStatsMenu()
    {
        StatisticsMenu.SetActive(true);
    }
    public void CloseStatsMenu()
    {
        StatisticsMenu.SetActive(false);
    }
    
    public void CloseAreYouSureMenu()
    {
        AreYouSureMenu.SetActive(false);
    }

    public void OpenRestartCheckMenu() {

        AreYouSureMenu.SetActive(true);
    }

    public void OpenOptionsMenu() {
        OptionsMenu.SetActive(true);
    }
    
    public void CloseOptionsMenu()
    {
        OptionsMenu.SetActive(false);
    }
}
