using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenMenu : MonoBehaviour
{
    public GameObject MenuCanvas;
    public GameObject StatisticsMenu;

    


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
        Scene scene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(scene.name);

    }
}
