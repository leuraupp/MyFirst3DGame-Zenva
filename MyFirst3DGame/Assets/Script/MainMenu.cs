using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void onStartGameClicked() {
        SceneManager.LoadScene(1);
    }

    public void onQuitClicked() {
        Application.Quit();
    }
}
