using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

    //PLAY BUTTON
    public void NewGameBtn(string newScene)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(newScene);
    }

    //CREDITS BUTTON
    public void OpenCreditSceneBtn(string creditScene)
    {
        SceneManager.LoadScene(creditScene);
    }
    public void BackToMenuBtn(string backToMenu)
    {
        SceneManager.LoadScene(backToMenu);
    }


    //EXIT BUTTON
    public void exitGameBtn()
    {
        Application.Quit();
    }
}
