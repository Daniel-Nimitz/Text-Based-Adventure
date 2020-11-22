using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLoad : MonoBehaviour
{
    public string sceneToLoad;


    public void LoadSceneFromMainMenu() {
        sceneToLoad = ES3.Load<string>("currentScene");
        SceneManager.LoadScene(sceneToLoad);
    }

}